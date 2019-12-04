using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface ISalesOrder_DetailService
    {
        Task CreateAsync(SalesOrder_DetailModel model);

        Task<SalesOrder_DetailModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<SalesOrder_DetailModel>> GetAllAsync();

        Task UpdateAsync(SalesOrder_DetailModel model);

        Task DeleteAsync(SalesOrder_DetailModel model);

    }
}