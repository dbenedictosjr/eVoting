using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface IPromoService
    {
        Task CreateAsync(PromoModel model);

        Task<PromoModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<PromoModel>> GetAllAsync();

        Task UpdateAsync(PromoModel model);

        Task DeleteAsync(PromoModel model);

    }
}