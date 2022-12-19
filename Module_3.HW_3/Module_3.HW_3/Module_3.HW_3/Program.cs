using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.HW_3
{
    public class Program
    {
        public void Show(bool result)
        {
            Console.WriteLine(result);
        }

        public static void Main(string[] args)
        {
            var class2 = new Class2(); 
            var class1 = new Class1();
            var program = new Program();
            Pow powDelegate = class1.Pow;
            var calculationResult = class2.Calc(powDelegate, 12, 6);
            var result = calculationResult.Invoke(24);
            program.Show(result);
        }
    }
}
