using Module_2.HW_5.Helpers;
using Module_2.HW_5.Models;
using Module_2.HW_5.Providers.Abstractions;
using Module_2.HW_5.Services.Abstractions;

namespace Module_2.HW_5
{
    public class App
    {
        private const int MethodsCount = 3;
        private readonly ILoggerService _loggerService;
        private readonly Actions _actions;
        private readonly IConfigProvider _configProvider;
        private readonly Random _random;

        public App(IConfigProvider configProvider, ILoggerService loggerService)
        {
            _loggerService = loggerService;
            _configProvider = configProvider;
            _random = new Random();
            _actions = new Actions(_loggerService);

            PrepareFiles();
        }

        public void Run(int countCycles = 100)
        {
            CallRandomMethods(countCycles);
        }

        private void PrepareFiles()
        {
            LoggerConfig loggerConfig = _configProvider.GetConfig().Logger;
            DirectoryInfo dirInfo = new (loggerConfig.DirectoryPath);
            int filesLimit = loggerConfig.FilesLimit;
            string dirPath = loggerConfig.DirectoryPath;
            string fileTitle = DateTime.UtcNow.ToString(loggerConfig.FileNameFormat);
            string extension = loggerConfig.FileExtension;
            string filePath = $"{dirPath}{fileTitle}{extension}";

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            else
            {
                string[]? files = Directory.GetFiles(loggerConfig.DirectoryPath);

                while (files.Length > filesLimit)
                {
                    Array.Sort(files, new FileComparer());
                    FileInfo fileInfo = new (files[0]);

                    fileInfo.Delete();
                    files = Directory.GetFiles(loggerConfig.DirectoryPath);
                }
            }

            _loggerService.SetOutput(filePath);
        }

        private void CallRandomMethods(int countCycles)
        {
            for (var i = 0; i < countCycles; i++)
            {
                int nextMethodIndex = _random.Next(MethodsCount);

                try
                {
                    switch (nextMethodIndex)
                    {
                        case 0:
                            _actions.StartMethod();
                            break;
                        case 1:
                            _actions.SkippedLogicInMethod();
                            break;
                        case 2:
                            _actions.ErrorMethod();
                            break;
                    }
                }
                catch (BusinessException e)
                {
                    _loggerService.LogWarning($"Action got this custom Exception: {e.Message}");
                }
                catch (Exception e)
                {
                    _loggerService.LogError($"Action failed by reason: {e}");
                }
            }
        }
    }
}
