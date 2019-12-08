using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface IGiftCheckService
    {
        Task CreateAsync(GiftCheckModel model);

        Task<GiftCheckModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<GiftCheckModel>> GetAllAsync();

        Task UpdateAsync(GiftCheckModel model);

        Task DeleteAsync(GiftCheckModel model);

    }
}