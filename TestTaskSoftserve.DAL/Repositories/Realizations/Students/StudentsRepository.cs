using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Student>> GetAllByIdsAsync(List<Guid> ids)
        {
            return await _db.Set<Student>().Where(s => ids.Contains(s.Id)).ToListAsync();
        }
    }
}
