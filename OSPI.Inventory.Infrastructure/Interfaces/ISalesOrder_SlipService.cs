using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Inventory.Infrastructure.Interfaces
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