using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskSoftserve.DAL.Entities;
using TestTaskSoftserve.DAL.Repositories.Interfaces;

namespace TestTaskSoftServe.DAL.Repositories.Interfaces.Students
{
    public interface IStudentsRepository : IRepositoryBase<Student>
    {
        Task<List<Student>> GetAllByIdsAsync(List<Guid> ids);
    }
}
