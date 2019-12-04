using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface ISalesOrder_SlipService
    {
        Task CreateAsync(SalesOrder_SlipModel model);

        Task<SalesOrder_SlipModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<SalesOrder_SlipModel>> GetAllAsync();

        Task UpdateAsync(SalesOrder_SlipModel model);

        Task DeleteAsync(SalesOrder_SlipModel model);

    }
}