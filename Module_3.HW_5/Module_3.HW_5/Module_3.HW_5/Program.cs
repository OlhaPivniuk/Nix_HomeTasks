using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Module_3.HW_5
{
    public class Program
    {        
        public static async Task<string> ReadHello()
        {
            string filepath = @"Hello.txt";
            string text = await File.ReadAllTextAsync(filepath);
            return text;
        }

        public static async Task<string> ReadWorld()
        {
            string filePath = @"World.txt";
            string text = await File.ReadAllTextAsync(filePath);
            return text;
        }

        public static async Task<string> Result()
        {
            List<Task<string>> result = new ();
            result.Add(ReadHello());
            result.Add(ReadWorld());
            string text = string.Join(" ", await Task.WhenAll(result));
            return text;
        }
        public static void Main(string[] args)
        {
            string text = Result().GetAwaiter().GetResult();
            Console.WriteLine(text);
        }
    }
}
