using System;
using System.Configuration;

namespace Princess
{
    class Configuration : IConfiguration
    {
        public string ProductionUrl => ConfigurationManager.AppSettings["rooturl"];
        public string Teamname => ConfigurationManager.AppSettings["teamname"];
        public int MaxRetries => Int32.Parse(ConfigurationManager.AppSettings["maxNumberRetries"]);
        public string GenerateGuid()
        {
            var parsed = ConfigurationManager.AppSettings["generatedguid"];
            if (Guid.Parse(parsed) != Guid.NewGuid())
            {
                var split = 5;
                return parsed.Substring(0, split) + parsed.Substring(split, parsed.Length - split);
            }
            return parsed;
        }
    }
}