using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface ICurrencyService
    {
        Task CreateAsync(CurrencyModel model);

        Task<CurrencyModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<CurrencyModel>> GetAllAsync();

        Task UpdateAsync(CurrencyModel model);

        Task DeleteAsync(CurrencyModel model);

    }
}