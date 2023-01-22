using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Module_4.HW_6.Services;

namespace Module_4.HW_6.DataAccess
{
    public class ContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var config = new ConfigService();
            var optionalBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionalBuilder.UseSqlServer(config.ConnectionString);

            return new ApplicationContext(optionalBuilder.Options);
        }
    }
}
