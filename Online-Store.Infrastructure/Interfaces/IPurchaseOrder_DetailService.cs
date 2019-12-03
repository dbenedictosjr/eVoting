using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface IPurchaseOrder_DetailService
    {
        Task CreateAsync(PurchaseOrder_DetailModel model);

        Task<PurchaseOrder_DetailModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<PurchaseOrder_DetailModel>> GetAllAsync();

        Task UpdateAsync(PurchaseOrder_DetailModel model);

        Task DeleteAsync(PurchaseOrder_DetailModel model);

    }
}