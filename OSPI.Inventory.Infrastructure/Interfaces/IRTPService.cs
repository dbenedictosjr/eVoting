using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Inventory.Infrastructure.Interfaces
{
    public interface IRTPService
    {
        Task CreateAsync(RTPModel model);

        Task<RTPModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<RTPModel>> GetAllAsync();

        Task UpdateAsync(RTPModel model);

        Task DeleteAsync(RTPModel model);

    }
}