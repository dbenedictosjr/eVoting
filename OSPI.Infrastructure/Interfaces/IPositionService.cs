using OSPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Infrastructure.Interfaces
{
    public interface IPositionService
    {
        Task CreateAsync(PositionModel model);

        Task<PositionModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<PositionModel>> GetAllAsync();

        Task UpdateAsync(PositionModel model);

        Task DeleteAsync(PositionModel model);

    }
}