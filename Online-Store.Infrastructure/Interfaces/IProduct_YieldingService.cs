using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface IProduct_YieldingService
    {
        Task CreateAsync(Product_YieldingModel model);

        Task<Product_YieldingModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<Product_YieldingModel>> GetAllAsync();

        Task UpdateAsync(Product_YieldingModel model);

        Task DeleteAsync(Product_YieldingModel model);

    }
}