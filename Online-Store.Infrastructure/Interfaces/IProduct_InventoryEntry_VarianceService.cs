using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface IProduct_InventoryEntry_VarianceService
    {
        Task CreateAsync(Product_InventoryEntry_VarianceModel model);

        Task<Product_InventoryEntry_VarianceModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<Product_InventoryEntry_VarianceModel>> GetAllAsync();

        Task UpdateAsync(Product_InventoryEntry_VarianceModel model);

        Task DeleteAsync(Product_InventoryEntry_VarianceModel model);

    }
}