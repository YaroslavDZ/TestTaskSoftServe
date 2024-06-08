using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskSoftserve.DAL.Database;
using TestTaskSoftserve.DAL.Entities;
using TestTaskSoftserve.DAL.Repositories.Interfaces;
using TestTaskSoftserve.DAL.Repositories.Realizations;
using TestTaskSoftServe.DAL.Repositories.Interfaces.Teachers;

namespace TestTaskSoftServe.DAL.Repositories.Realizations.Teachers
{
    public class TeachersRepository : RepositoryBase<Teacher>, ITeachersRepository
    {
        public TeachersRepository(UniversityDbContext dbContext) : base(dbContext)
        {

        }
    }
}
