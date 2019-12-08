using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Inventory.Infrastructure.Interfaces
{
    public interface IDiscountService
    {
        Task CreateAsync(DiscountModel model);

        Task<DiscountModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<DiscountModel>> GetAllAsync();

        Task UpdateAsync(DiscountModel model);

        Task DeleteAsync(DiscountModel model);

    }
}