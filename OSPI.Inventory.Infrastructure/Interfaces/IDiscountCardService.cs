using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Inventory.Infrastructure.Interfaces
{
    public interface IDiscountCardService
    {
        Task CreateAsync(DiscountCardModel model);

        Task<DiscountCardModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<DiscountCardModel>> GetAllAsync();

        Task UpdateAsync(DiscountCardModel model);

        Task DeleteAsync(DiscountCardModel model);

    }
}