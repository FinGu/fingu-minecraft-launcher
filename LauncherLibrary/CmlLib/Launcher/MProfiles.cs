﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CmlLib.Launcher
{
    public class MProfile
    {
        public static MProfile FindProfile(MProfileInfo[] infos, string name)
        {
            MProfile startProfile = null;
            MProfile baseProfile = null;

            foreach (var item in infos)
            {
                if (item.Name == name)
                {
                    startProfile = Parse(item);
                    break;
                }
            }

            if (startProfile.IsInherted)
            {
                baseProfile = FindProfile(infos, startProfile.ParentProfileId);
                inhert(baseProfile, startProfile);
            }

            return startProfile;
        }

        [Obsolete("Use 'FindProfile' Method.")]
        public static MProfile GetProfile(MProfileInfo[] infos, string name)
        {
            return FindProfile(infos, name);
        }

        public static MProfile Parse(MProfileInfo info)
        {
            string json;
            if (info.IsWeb)
            {
                using (var wc = new WebClient())
                {
                    json = wc.DownloadString(info.Path);
                    return ParseFromJson(json, true);
                }
            }
            else
                return ParseFromFile(info.Path);
        }

        public static MProfile ParseFromFile(string path)
        {
            var json = File.ReadAllText(path);
            return ParseFromJson(json, false);
        }

        private static MProfile ParseFromJson(string json, bool writeProfile = true)
        {
            var profile = new MProfile();
            var job = JObject.Parse(json);
            profile.Id = job["id"]?.ToString();

            var assetindex = (JObject)job["assetIndex"];
            if (assetindex != null)
            {
                profile.AssetId = n(assetindex["id"]?.ToString());
                profile.AssetUrl = n(assetindex["url"]?.ToString());
                profile.AssetHash = n(assetindex["sha1"]?.ToString());
            }

            var client = job["downloads"]?["client"];
            if (client != null)
            {
                profile.ClientDownloadUrl = client["url"]?.ToString();
                profile.ClientHash = client["sha1"]?.ToString();
            }

            profile.Libraries = MLibrary.Parser.ParseJson((JArray)job["libraries"]);
            profile.MainClass = n(job["mainClass"]?.ToString());

            var ma = job["minecraftArguments"]?.ToString();
            if (ma != null)
                profile.MinecraftArguments = ma;

            var ag = job["arguments"];
            if (ag != null)
            {
                if (ag["game"] != null)
                    profile.GameArguments = argParse((JArray)ag["game"]);
                if (ag["jvm"] != null)
                    profile.JvmArguments = argParse((JArray)ag["jvm"]);
            }

            profile.ReleaseTime = job["releaseTime"]?.ToString();

            var ype = job["type"]?.ToString();
            profile.TypeStr = ype;
            profile.Type = MProfileTypeConverter.FromString(ype);

            if (job["inheritsFrom"] != null)
            {
                profile.IsInherted = true;
                profile.ParentProfileId = job["inheritsFrom"].ToString();
            }
            else
                profile.Jar = profile.Id;

            if (writeProfile)
            {
                var path = Minecraft.Versions + profile.Id;
                Directory.CreateDirectory(path);
                File.WriteAllText(path + "\\" + profile.Id + ".json", json);
            }

            return profile;
        }

        static string[] argParse(JArray arr)
        {
            var strList = new List<string>(arr.Count);
            var ruleChecker = new MRule();

            foreach (var item in arr)
            {
                if (item is JObject)
                {
                    bool allow = true;

                    if (item["rules"] != null)
                        allow = ruleChecker.CheckOSRequire((JArray)item["rules"]);

                    var value = item["value"];
                    if (allow && value != null)
                    {
                        if (value is JArray)
                        {
                            foreach (var str in value)
                            {
                                strList.Add(str.ToString());
                            }
                        }
                        else
                            strList.Add(value.ToString());
                    }
                }
                else
                    strList.Add(item.ToString());
            }

            return strList.ToArray();
        }

        static MProfile inhert(MProfile parentProfile, MProfile childProfile)
        {
            // Inhert list
            // Overload : AssetId, AssetUrl, AssetHash, ClientDownloadUrl, ClientHash, MainClass, MinecraftArguments
            // Combine : Libraries, GameArguments, JvmArguments

            // Overloads

            if (nc(childProfile.AssetId))
                childProfile.AssetId = parentProfile.AssetId;

            if (nc(childProfile.AssetUrl))
                childProfile.AssetUrl = parentProfile.AssetUrl;

            if (nc(childProfile.AssetHash))
                childProfile.AssetHash = parentProfile.AssetHash;

            if (nc(childProfile.ClientDownloadUrl))
                childProfile.ClientDownloadUrl = parentProfile.ClientDownloadUrl;

            if (nc(childProfile.ClientHash))
                childProfile.ClientHash = parentProfile.ClientHash;

            if (nc(childProfile.MainClass))
                childProfile.MainClass = parentProfile.MainClass;

            if (nc(childProfile.MinecraftArguments))
                childProfile.MinecraftArguments = parentProfile.MinecraftArguments;

            childProfile.Jar = parentProfile.Jar;

            // Combine

            if (parentProfile.Libraries != null)
            {
                if (childProfile.Libraries != null)
                    childProfile.Libraries = childProfile.Libraries.Concat(parentProfile.Libraries).ToArray();
                else
                    childProfile.Libraries = parentProfile.Libraries;
            }

            if (parentProfile.GameArguments != null)
            {
                if (childProfile.GameArguments != null)
                    childProfile.GameArguments = childProfile.GameArguments.Concat(parentProfile.GameArguments).ToArray();
                else
                    childProfile.GameArguments = parentProfile.GameArguments;
            }


            if (parentProfile.JvmArguments != null)
            {
                if (childProfile.JvmArguments != null)
                    childProfile.JvmArguments = childProfile.JvmArguments.Concat(parentProfile.JvmArguments).ToArray();
                else
                    childProfile.JvmArguments = parentProfile.JvmArguments;
            }

            return childProfile;
        }

        static string n(string t) // handle null string
        {
            return (t == null) ? "" : t;
        }

        static bool nc(string t) // check null string
        {
            return (t == null) || (t == "");
        }

        public bool IsWeb { get; private set; }

        public bool IsInherted { get; private set; } = false;
        public string ParentProfileId { get; private set; } = "";

        public string Id { get; private set; } = "";

        public string AssetId { get; private set; } = "";
        public string AssetUrl { get; private set; } = "";
        public string AssetHash { get; private set; } = "";

        public string Jar { get; private set; } = "";
        public string ClientDownloadUrl { get; private set; } = "";
        public string ClientHash { get; private set; } = "";
        public MLibrary[] Libraries { get; private set; }
        public string MainClass { get; private set; } = "";
        public string MinecraftArguments { get; private set; } = "";
        public string[] GameArguments { get; private set; }
        public string[] JvmArguments { get; private set; }
        public string ReleaseTime { get; private set; } = "";
        public MProfileType Type { get; private set; } = MProfileType.Custom;

        public string TypeStr { get; private set; } = "";

        public string NativePath { get; set; } = "";
    }
}
