using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Inventory.Infrastructure.Interfaces
{
    public interface IProductParStock_DetailService
    {
        Task CreateAsync(ProductParStock_DetailModel model);

        Task<ProductParStock_DetailModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<ProductParStock_DetailModel>> GetAllAsync();

        Task UpdateAsync(ProductParStock_DetailModel model);

        Task DeleteAsync(ProductParStock_DetailModel model);

    }
}