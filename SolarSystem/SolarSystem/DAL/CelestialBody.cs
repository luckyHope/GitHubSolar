using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.DAL
{
    class CelestialBody
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public long Temperature { get; set; }
        public long Mass { get; set; }
        public long Orbit { get; set; }
        public long Diametre { get; set; }
        public List<Planet> Planets { get; set; }
        public List <Moon> Moons { get; set; }
    }
}
