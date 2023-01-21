using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Module_4.HW_3.Entities;
using Module_4.HW_3.DBConfigurations;

namespace Module_4.HW_3
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Title> Title { get; set; }
        public DbSet<Office> Office { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<EmployeeProject> EmployeeProject { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new TitleConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.Write);
        }
    }
}
