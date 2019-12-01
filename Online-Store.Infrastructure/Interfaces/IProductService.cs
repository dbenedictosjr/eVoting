using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface IProductService
    {
        Task CreateAsync(ProductModel model);

        Task<ProductModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<ProductModel>> GetAllAsync();

        Task UpdateAsync(ProductModel model);

        Task DeleteAsync(ProductModel model);

    }
}