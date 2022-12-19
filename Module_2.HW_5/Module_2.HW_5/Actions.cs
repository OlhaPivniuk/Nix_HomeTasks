using Module_2.HW_5.Helpers;
using Module_2.HW_5.Services.Abstractions;

namespace Module_2.HW_5
{
    public class Actions
    {
        readonly ILoggerService _loggerService;

        public Actions(ILoggerService loggerService)
        {
            _loggerService = loggerService;
        }

        public bool StartMethod()
        {
            _loggerService.LogInfo($"Start method: {nameof(StartMethod)}");

            return true;
        }

        public bool SkippedLogicInMethod()
        {
            throw new BusinessException("Skipped logic in method");
        }

        public bool ErrorMethod()
        {
            throw new Exception("I broke a logic");
        }
    }
}
