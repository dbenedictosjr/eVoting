using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface IPurchaseOrderService
    {
        Task CreateAsync(PurchaseOrderModel model);

        Task<PurchaseOrderModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<PurchaseOrderModel>> GetAllAsync();

        Task UpdateAsync(PurchaseOrderModel model);

        Task DeleteAsync(PurchaseOrderModel model);

    }
}