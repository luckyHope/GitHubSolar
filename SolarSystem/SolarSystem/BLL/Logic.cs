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
            Solar.Planets.Add(new Planet{Name = "Upiter", Type = "Planet", Diametre = 23234234234, Mass = 2523525345,
                                            Moons = new List<Moon>
                                            {
                                                new Moon {Type = "Moon", Name = "Andromeda", Diametre = 4564564, Mass = 566346452},
                                                new Moon {Type = "Moon", Name = "Selesta", Diametre = 4564564, Mass = 566346452},
                                                new Moon {Type = "Moon", Name = "Ginerva", Diametre = 4564564, Mass = 566346452},
                                                new Moon {Type = "Moon", Name = "Lirgonda", Diametre = 4564564, Mass = 566346452}
                                            }
                                        });
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
