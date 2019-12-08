using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Inventory.Infrastructure.Interfaces
{
    public interface IStatusService
    {
        Task CreateAsync(StatusModel model);

        Task<StatusModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<StatusModel>> GetAllAsync();

        Task UpdateAsync(StatusModel model);

        Task DeleteAsync(StatusModel model);

    }
}