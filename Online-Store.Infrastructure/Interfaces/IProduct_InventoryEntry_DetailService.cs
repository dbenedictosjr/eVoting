using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface IProduct_InventoryEntry_DetailService
    {
        Task CreateAsync(Product_InventoryEntry_DetailModel model);

        Task<Product_InventoryEntry_DetailModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<Product_InventoryEntry_DetailModel>> GetAllAsync();

        Task UpdateAsync(Product_InventoryEntry_DetailModel model);

        Task DeleteAsync(Product_InventoryEntry_DetailModel model);

    }
}