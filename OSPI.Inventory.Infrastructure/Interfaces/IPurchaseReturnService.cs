using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Inventory.Infrastructure.Interfaces
{
    public interface IPurchaseReturnService
    {
        Task CreateAsync(PurchaseReturnModel model);

        Task<PurchaseReturnModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<PurchaseReturnModel>> GetAllAsync();

        Task UpdateAsync(PurchaseReturnModel model);

        Task DeleteAsync(PurchaseReturnModel model);

    }
}