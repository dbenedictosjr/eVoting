using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface IProduct_UnitService
    {
        Task CreateAsync(Product_UnitModel model);

        Task<Product_UnitModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<Product_UnitModel>> GetAllAsync();

        Task UpdateAsync(Product_UnitModel model);

        Task DeleteAsync(Product_UnitModel model);

    }
}