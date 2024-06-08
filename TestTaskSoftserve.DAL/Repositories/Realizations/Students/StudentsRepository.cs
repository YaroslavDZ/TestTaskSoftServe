using TestTaskSoftserve.DAL.Database;
using TestTaskSoftserve.DAL.Entities;
using TestTaskSoftserve.DAL.Repositories.Realizations;
using TestTaskSoftServe.DAL.Repositories.Interfaces.Students;

namespace TestTaskSoftServe.DAL.Repositories.Realizations.Students
{
    public class StudentsRepository : RepositoryBase<Student>, IStudentsRepository
    {
        public StudentsRepository(UniversityDbContext dbContext) : base(dbContext)
        {

        }
    }
}
