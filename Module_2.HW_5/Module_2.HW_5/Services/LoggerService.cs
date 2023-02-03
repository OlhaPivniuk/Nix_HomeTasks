using Module_2.HW_5.Models.Enums;
using Module_2.HW_5.Models;
using Module_2.HW_5.Providers.Abstractions;
using Module_2.HW_5.Services.Abstractions;

namespace Module_2.HW_5.Services
{
    public class LoggerService : ILoggerService
    {
        private readonly IFileService _fileService;
        private readonly LoggerConfig _loggerConfig;
        private IDisposable _fileWriter;

        public LoggerService(IFileService fileService, IConfigProvider configProvider) 
        {
            _fileService = fileService;
            _loggerConfig = configProvider.GetConfig().Logger;
        }

        ~LoggerService()
        {
            _fileService.Close(_fileWriter);
        }

        public void LogError(string message)
        {
            Log(message, LogType.Error);
        }

        public void LogInfo(string message)
        {
            Log(message, LogType.Info);
        }

        public void LogWarning(string message)
        {
            Log(message, LogType.Warning);
        }

        public void SetOutput(string filePath)
        {
            _fileWriter = _fileService.Create(filePath);
        }

        private void Log(string message, LogType logType)
        {
            var logItem = $"{DateTime.UtcNow.ToString(_loggerConfig.TimeFormat)}: {logType.ToString()}: {message}";

            Console.WriteLine(logItem);
            _fileService.Write(_fileWriter, logItem);
        }
    }
}
