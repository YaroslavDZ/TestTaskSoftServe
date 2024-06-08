using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskSoftserve.DAL.Database;
using TestTaskSoftserve.DAL.Entities;
using TestTaskSoftserve.DAL.Repositories.Realizations;
using TestTaskSoftServe.DAL.Repositories.Interfaces.Courses;

namespace TestTaskSoftServe.DAL.Repositories.Realizations.Courses
{
    public class CoursesRepository : RepositoryBase<Course>, ICoursesRepository
    {
        public CoursesRepository(UniversityDbContext dbContext) : base(dbContext)
        {

        }
    }
}
