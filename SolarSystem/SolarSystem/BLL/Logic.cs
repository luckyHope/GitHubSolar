using System;
using System.Collections.Generic;
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
        public Star Solar { get; set; }
        public Logic(string ssd)
        {
            Solar = JsonConvert.DeserializeObject<Star>(ssd);
        }
    }
}
