using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.HW_4.TaskDelegate
{
    public class MethodDelegate
    {
        private Func<int, int, int> _sum;

        public void TryCatch(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int Sum()
        {
            _sum += (x, y) => x + y;
            _sum += (x, y) => x + y;
            var res_sum = 0;
            var result = _sum.GetInvocationList();

            foreach (var item in result)
            {
                var sum = item.DynamicInvoke(2, 5);
                res_sum += (int)sum;
            }

            return res_sum;
        }
    }
}
