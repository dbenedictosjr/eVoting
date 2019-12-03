using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface IProduct_InventoryService
    {
        Task CreateAsync(Product_InventoryModel model);

        Task<Product_InventoryModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<Product_InventoryModel>> GetAllAsync();

        Task UpdateAsync(Product_InventoryModel model);

        Task DeleteAsync(Product_InventoryModel model);

    }
}