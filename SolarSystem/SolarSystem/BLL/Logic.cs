using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using SolarSystem.DAL;

namespace SolarSystem.BLL
{
    class Logic
    {
        private string directory;
        public Star Solar { get; set; }
        private string json;
        public Logic(string ssd, string directory)
        {
            this.directory = directory;
            Solar = JsonConvert.DeserializeObject<Star>(ssd);
        }

        public void CreatePlanet()
        {
           
        }
        public void CreateMoon()
        {
            
        }
        public void RewriteFile()
        {
            json = JsonConvert.SerializeObject(Solar);
            File.WriteAllText(directory, json);
        }

    }
}
