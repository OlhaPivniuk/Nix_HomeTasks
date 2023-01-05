using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.HW_7
{
    internal class Program
    {
        public static string path => "TextFile.txt";
        async static Task Main(string[] args)
        {

            Starter starter = new ();

            await starter.RunAsync();
        }
    }
}
