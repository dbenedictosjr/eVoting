using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface IProduct_InventoryEntryService
    {
        Task CreateAsync(Product_InventoryEntryModel model);

        Task<Product_InventoryEntryModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<Product_InventoryEntryModel>> GetAllAsync();

        Task UpdateAsync(Product_InventoryEntryModel model);

        Task DeleteAsync(Product_InventoryEntryModel model);

    }
}