using Module_4.HW_6.Configurations;
using Newtonsoft.Json;

namespace Module_4.HW_6.Services
{
    public class ConfigService
    {
        private readonly string _filePath = "Config.json";
        private readonly ConnectionStringConfig _connectionStringConfig;

        public ConfigService()
        {
            _connectionStringConfig = GetConfig();
        }
        public string ConnectionString => _connectionStringConfig.ConnectionString;

        private ConnectionStringConfig GetConfig()
        {
            var configFile = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<ConnectionStringConfig>(configFile);
        }
    }
}
