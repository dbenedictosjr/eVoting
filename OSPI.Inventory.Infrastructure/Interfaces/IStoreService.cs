using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Inventory.Infrastructure.Interfaces
{
    public interface IStoreService
    {
        Task CreateAsync(StoreModel model);

        Task<StoreModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<StoreModel>> GetAllAsync();

        Task UpdateAsync(StoreModel model);

        Task DeleteAsync(StoreModel model);

    }
}