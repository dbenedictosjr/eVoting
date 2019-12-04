using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface ITotalSalesService
    {
        Task CreateAsync(TotalSalesModel model);

        Task<TotalSalesModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<TotalSalesModel>> GetAllAsync();

        Task UpdateAsync(TotalSalesModel model);

        Task DeleteAsync(TotalSalesModel model);

    }
}