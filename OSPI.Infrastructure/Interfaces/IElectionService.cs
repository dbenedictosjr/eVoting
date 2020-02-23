using OSPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Infrastructure.Interfaces
{
    public interface IElectionService
    {
        Task CreateAsync(ElectionModel model);

        Task<ElectionModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<ElectionModel>> GetAllAsync();

        Task UpdateAsync(ElectionModel model);

        Task DeleteAsync(ElectionModel model);

    }
}