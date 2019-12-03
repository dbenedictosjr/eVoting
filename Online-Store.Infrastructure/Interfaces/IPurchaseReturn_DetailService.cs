using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface IPurchaseReturn_DetailService
    {
        Task CreateAsync(PurchaseReturn_DetailModel model);

        Task<PurchaseReturn_DetailModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<PurchaseReturn_DetailModel>> GetAllAsync();

        Task UpdateAsync(PurchaseReturn_DetailModel model);

        Task DeleteAsync(PurchaseReturn_DetailModel model);

    }
}