using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskSoftserve.DAL.Entities;
using TestTaskSoftserve.DAL.Repositories.Interfaces;

namespace TestTaskSoftServe.DAL.Repositories.Interfaces.Teachers
{
    public interface ITeachersRepository : IRepositoryBase<Teacher>
    {
        Task<IEnumerable<Teacher>> GetAllByIdsAsync(List<Guid> ids);
    }
}
