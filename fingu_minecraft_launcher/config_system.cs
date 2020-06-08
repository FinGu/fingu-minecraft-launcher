using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fingu_minecraft_launcher
{
    class config_system
    {
        #region definitions
        private readonly static string path = "config.json";
        public string version { get; set; }
        public string max_ram { get; set; }
        public string java_path { get; set; }
        public string mc_path { get; set; }
        #endregion
        
        public void save() {
            var json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(path, json); 
        }
        public static void create() {
            config_system _default = new config_system() {
                java_path = "javaw.exe",
                max_ram = "1024",
                mc_path = Environment.GetEnvironmentVariable("APPDATA") + "\\.minecraft",
                version = null
            };

            File.WriteAllText(path, JsonConvert.SerializeObject(_default));
        }
        public static config_system load() {
            var json = File.ReadAllText(path); 
            return JsonConvert.DeserializeObject<config_system>(json);
        }
    }
}
