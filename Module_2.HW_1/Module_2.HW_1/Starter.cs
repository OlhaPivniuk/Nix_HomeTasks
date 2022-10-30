using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW1
{
    public class Starter
    {
        readonly Logger logger = Logger.GetInstance();
        public void Run()
        {
            List<Func<Result>> methods = new List<Func<Result>>();
            Actions action = new Actions();
            methods.Add(action.StartMethod);
            methods.Add(action.SkippedLogicInMethod);
            methods.Add(action.ErrorMethod);

            for (int i = 0; i <= 100; i++)
            {
                Random rnd = new System.Random();
                int methodIndex = rnd.Next(methods.Count);
                Result resultOfRandomMethod = methods[methodIndex]();

                if (resultOfRandomMethod.Status == false)

                {
                    logger.WriteLog($"Action failed by a reason: {resultOfRandomMethod.ErrorMessage}", LogType.Error);
                }
            }
            logger.Save();
        }
    }
}
