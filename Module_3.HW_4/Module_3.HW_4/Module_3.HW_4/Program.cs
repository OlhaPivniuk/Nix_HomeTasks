using Module_3.HW_4.TaskDelegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.HW_4.TaskLinq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var methodDelegate = new MethodDelegate();
            var total_sum = 0;
            methodDelegate.TryCatch(() =>
            {
                total_sum = methodDelegate.Sum();
            });
            Console.WriteLine(total_sum);
            var res = new Starter();
            res.FillData();
        }
    }
}
