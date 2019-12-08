using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Inventory.Infrastructure.Interfaces
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