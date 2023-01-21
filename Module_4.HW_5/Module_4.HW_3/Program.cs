using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Module_4.HW_5
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var starter = new Starter();
            starter.Run();
        }
    }
}
