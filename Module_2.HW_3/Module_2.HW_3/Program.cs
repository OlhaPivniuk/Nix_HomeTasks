using System;
using Module_2.HW_3.Model;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Module_2.HW_3
{
    class Program
    {
        static void Main()
        {
            string l = " ";

            Salad salad = new Salad();
            salad.ReadingFile("input.txt");

            Console.WriteLine("Initial data");
            Console.Write(salad);
            Console.WriteLine(l);

            Console.WriteLine("Total calories in your salad: " + salad.СountСalories());
            Console.WriteLine(l);
           
            salad._Salad.Sort();
            Console.WriteLine("Sorted vegetables by calories");
            Console.Write(salad);
            Console.WriteLine(l);
            
            salad.WriteToFile("output.txt");
            
            double lowerLimit;
            Console.Write("Enter your lower calorie limit: ");
            lowerLimit = Convert.ToDouble(Console.ReadLine());
            double upperLimit;
            Console.Write("Enter your upper calorie limit: ");
            upperLimit = Convert.ToDouble(Console.ReadLine());
            foreach (var element in salad._Salad)
            {
                if (element.Caloricity >= lowerLimit && element.Caloricity <= upperLimit)
                {
                    Console.WriteLine(element.ToString());
                }
            }
            Console.WriteLine(l);

            Console.ReadKey();
        }
    }
}
