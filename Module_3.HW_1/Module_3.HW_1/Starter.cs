using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.HW_1
{
    public class Starter
    {
        public void Run()
        {
            ArrayList<int> intList = new();
            ListInfo(intList);

            int[] intArray = new int[] { 100, 101, 501, 601, 701, 201, 301, 901, 1000, 401, 801};

            for (int i = 0; i < 10; i++)
            {
                intList.Add(i);
            }

            ListInfo(intList);

            intList.AddRange(intArray);
            ListInfo(intList);

            intList.RemoveAt(3);
            ListInfo(intList);
            intList.Remove(201);
            ListInfo(intList);            

            intList.Sort();
            ListInfo(intList);

            ArrayList<string> stringList = new(6);
            ListInfo(stringList);

            string[] stringArray = new string[] { "Ivan", "Petro", "Artur", "Vlad", "Ihor", "Serge", "Alex", "Oleh", "Taras" };

            stringList.Add("Olha");
            stringList.Add("Anna");
            stringList.Add("Iryna");
            stringList.Add("Natalia");
            stringList.Add("Inga");
            ListInfo(stringList);            

            stringList.AddRange(stringArray);
            ListInfo(stringList);            

            stringList.Sort();
            ListInfo(stringList);            

            Console.ReadKey();
        }

        private void ListInfo<T>(ArrayList<T> arrayList)
        {
            Console.WriteLine(string.Empty);
            Console.WriteLine("-------------------------------");
            Console.WriteLine($" Number of items:         {arrayList.Count}");
            Console.WriteLine($" Capacity of the array:   {arrayList.Capacity}");

            if (arrayList.Count > 0)
            {
                Console.WriteLine(string.Empty);
                Console.WriteLine(" Items:");

                foreach (var item in arrayList)
                {
                    Console.Write($" {item}");
                }

                Console.WriteLine(string.Empty);
            }

            Console.WriteLine("-------------------------------");
        }
    }
}
