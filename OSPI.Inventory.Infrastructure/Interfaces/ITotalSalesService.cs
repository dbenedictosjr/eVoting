using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Inventory.Infrastructure.Interfaces
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