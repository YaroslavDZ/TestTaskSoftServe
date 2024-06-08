using Microsoft.EntityFrameworkCore;
using TestTaskSoftserve.DAL.Database;

namespace Test_Task_SoftServe.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services,
            ConfigurationManager configuration)
        { 
            var dbConnectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<UniversityDbContext>(
                options =>
                {
                    options.UseMySql(dbConnectionString, new MySqlServerVersion(new Version(8, 0, 36)));
                });
        }
    }
}
