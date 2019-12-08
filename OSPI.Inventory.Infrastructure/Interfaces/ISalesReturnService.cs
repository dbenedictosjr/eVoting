using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Inventory.Infrastructure.Interfaces
{
    public interface ISalesReturnService
    {
        Task CreateAsync(SalesReturnModel model);

        Task<SalesReturnModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<SalesReturnModel>> GetAllAsync();

        Task UpdateAsync(SalesReturnModel model);

        Task DeleteAsync(SalesReturnModel model);

    }
}