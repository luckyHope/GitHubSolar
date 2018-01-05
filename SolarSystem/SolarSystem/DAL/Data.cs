using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SolarSystem.DAL
{
    class Data
    { 
        string SSData { get; set; }
        public Data(string directory)
        {
            using (FileStream filestream = File.OpenRead(directory))
            {
                using (StreamReader streamReader = new StreamReader(filestream))
                {
                    while (!streamReader.EndOfStream)

                    {
                        string line = streamReader.ReadLine();
                        SSData +=line;
                    }
                }
            }
            Star solar = JsonConvert.DeserializeObject<Star>(SSData);
        }
    }
}
