using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;
using TestTaskSoftserve.DAL.Database;
using TestTaskSoftServe.BLL.Services.Interfaces;
using TestTaskSoftServe.BLL.Services.Interfaces.Authentification;
using TestTaskSoftServe.BLL.Services.Realizations;
using TestTaskSoftServe.BLL.Services.Realizations.Authentification;
using TestTaskSoftServe.DAL.Repositories.Interfaces.Courses;
using TestTaskSoftServe.DAL.Repositories.Interfaces.Students;
using TestTaskSoftServe.DAL.Repositories.Interfaces.Teachers;
using TestTaskSoftServe.DAL.Repositories.Realizations.Courses;
using TestTaskSoftServe.DAL.Repositories.Realizations.Students;
using TestTaskSoftServe.DAL.Repositories.Realizations.Teachers;

namespace Test_Task_SoftServe.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services,
            ConfigurationManager configuration)
        {
            var dbConnectionString = configuration["Connections:DefaultConnection"];

            services.AddDbContext<UniversityDbContext>(
                options =>
                {
                    options.UseMySql(dbConnectionString, ServerVersion.AutoDetect(dbConnectionString));
                });
        }

        public static void AddCustomServices(this IServiceCollection services)
        {
            var currentAssemblies = AppDomain.CurrentDomain.GetAssemblies();
            services.AddAutoMapper(currentAssemblies);


            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddTransient<IJwtService, JwtService>();
        }

        public static void AddCustomRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICoursesRepository, CoursesRepository>();
            services.AddScoped<ITeachersRepository, TeachersRepository>();
            services.AddScoped<IStudentsRepository, StudentsRepository>();
        }

        public static void AddSwaggerServices(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(opt =>
            {
                opt.SwaggerDoc("v1", new OpenApiInfo { Title = "Test-Task-SoftServe", Version = "v1" });
                opt.CustomSchemaIds(x => x.FullName);

                opt.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());

                opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please insert JWT with Bearer into field",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });

                opt.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                     new OpenApiSecurityScheme
                     {
                           Reference = new OpenApiReference
                           {
                             Type = ReferenceType.SecurityScheme,
                             Id = "Bearer"
                           }
                     },
                     new string[] { }
                }
            });
            });
        }
    }
}
