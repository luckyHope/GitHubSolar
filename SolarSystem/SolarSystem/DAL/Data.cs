using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.DAL
{
    class Data
    { 
        public List <string> SSData { get; set; }
        public Data(string directory)
        {
            using (FileStream filestream = File.OpenRead(directory))
            {
                using (StreamReader streamReader = new StreamReader(filestream))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string line = streamReader.ReadLine();
                        SSData.Add(line);
                    }
                }
            }
        }
    }
}
