namespace Module2HW1
{
    public class Actions
    {
        readonly Logger logger = Logger.GetInstance();

        public Result StartMethod()
        {
            logger.WriteLog($"Start method: {StartMethod}", LogType.Info);
            Result result = new();
            result.Status = true;
            return result;
        }
        public Result SkippedLogicInMethod()
        {
            logger.WriteLog($"Skipped logic in method: {StartMethod}", LogType.Warning);
            Result result = new();
            result.Status = true;
            return result;
        }
        public Result ErrorMethod()
        {
            logger.WriteLog($"Method: {ErrorMethod}", LogType.Error);
            Result result = new();
            result.Status = false;
            result.ErrorMessage = "I broke a logic";
            return result;
        }
    }
}