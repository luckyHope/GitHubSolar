using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolarSystem.DAL;
using SolarSystem.TestFolder;

namespace SolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = ConfigurationManager.AppSettings.Get("directory");
            DAL.Data data = new Data(directory);

        }
    }
}
