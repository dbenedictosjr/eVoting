using OSPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Infrastructure.Interfaces
{
    public interface IPositionService
    {
        Task CreateAsync(PositionModel position);

        Task<PositionModel> GetByIdAsync(Guid? id);
        Task<IEnumerable<PositionModel>> GetByAllByElectionIdAsync(Guid? id);
        Task<IEnumerable<PositionModel>> GetAllAsync();

        Task UpdateAsync(PositionModel position);

        Task DeleteAsync(PositionModel position);

    }
}