using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface IProductParStockService
    {
        Task CreateAsync(ProductParStockModel model);

        Task<ProductParStockModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<ProductParStockModel>> GetAllAsync();

        Task UpdateAsync(ProductParStockModel model);

        Task DeleteAsync(ProductParStockModel model);

    }
}