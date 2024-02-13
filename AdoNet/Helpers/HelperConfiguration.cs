using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Helpers
{
    internal class HelperConfiguration
    {
        public static string GetConnectionString()
        {
            //cargas fichero
            IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("config.json", true, true);
            //recuperamos clase con values json
            IConfigurationRoot config = builder.Build();
            string connectionString = config["SqlHospital"];
            return connectionString;
        }
    }
}
