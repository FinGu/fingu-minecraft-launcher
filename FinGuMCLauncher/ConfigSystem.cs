using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinGuMCLauncher
{
    class ConfigSystem
    {
        private readonly static string path = "config.json";
        public string Version { get; set; }
        public string MaxRam { get; set; }
        public string JavaPath { get; set; }
        public string MCPath { get; set; }
        public void Save()
        {
            var json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(path, json); 
        }
        public static void Create()
        {
            var json = @"{ 
			    Version: null, 
				MaxRam: null, 
                JavaPath: null, 
				MCPath: null }";
            File.WriteAllText(path, json);
        }
        public static ConfigSystem Load()
        {
            var json = File.ReadAllText(path); 
            return JsonConvert.DeserializeObject<ConfigSystem>(json);
        }
    }
}
