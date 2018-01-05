using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolarSystem.BLL;
using SolarSystem.DAL;
using SolarSystem.TestFolder;

namespace SolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = ConfigurationManager.AppSettings.Get("directory");
            string solarSystemData;
            DAL.Data data = new Data(directory);
            solarSystemData = data.SSData;
            BLL.Logic logic = new Logic(solarSystemData);

        }
    }
}
