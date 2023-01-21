using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Module_4.HW_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("config.json").Build();
            var dbOptionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var connectionString = configuration.GetConnectionString("Module_4.HW_3");
            dbOptionsBuilder.UseSqlServer(connectionString, i => i.CommandTimeout(20));

            var applicationContext = new ApplicationContext(dbOptionsBuilder.Options);
            applicationContext.SaveChanges();
        }
    }
}
