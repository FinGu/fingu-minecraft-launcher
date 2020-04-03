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
        #region Definitions
        private readonly static string path = "config.json";
        public string Version { get; set; }
        public string MaxRam { get; set; }
        public string JavaPath { get; set; }
        public string MCPath { get; set; }
        #endregion
        public void Save() {
            var json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(path, json); 
        }
        public static void Create() {
            ConfigSystem _default = new ConfigSystem();
            _default.JavaPath = "javaw.exe";
            _default.MaxRam = "1024";
            _default.MCPath = Environment.GetEnvironmentVariable("APPDATA") + "\\.minecraft";
            _default.Version = null;

            File.WriteAllText(path, JsonConvert.SerializeObject(_default));
        }
        public static ConfigSystem Load() {
            var json = File.ReadAllText(path); 
            return JsonConvert.DeserializeObject<ConfigSystem>(json);
        }
    }
}
