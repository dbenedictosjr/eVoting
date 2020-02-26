using OSPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Infrastructure.Interfaces
{
    public interface IElectionService
    {
        Task CreateAsync(ElectionModel election);

        Task<ElectionModel> GetByIdAsync(Guid? id);
        Task<IEnumerable<ElectionModel>> GetAllAsync();

        Task UpdateAsync(ElectionModel election);

        Task DeleteAsync(ElectionModel election);

    }
}