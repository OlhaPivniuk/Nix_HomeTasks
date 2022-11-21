using Module_2.HW_5.Models;
using Module_2.HW_5.Providers.Abstractions;
using Module_2.HW_5.Services.Abstractions;
using Newtonsoft.Json;

namespace Module_2.HW_5.Providers
{
    public class ConfigProvider : IConfigProvider
    {
        private const string ConfigPath = "config.json";
        private readonly IFileService _fileService;

        public ConfigProvider(IFileService fileService)
        {
            _fileService = fileService;
            Config = LoadFromFile();
        }

        private Config Config { get; init; }

        public Config GetConfig()
        {
            return Config;
        }

        private Config LoadFromFile()
        {
            string configFile = _fileService.Read(ConfigPath);

            return JsonConvert.DeserializeObject<Config>(configFile);
        }
    }
}
