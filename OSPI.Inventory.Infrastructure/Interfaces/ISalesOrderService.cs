using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Inventory.Infrastructure.Interfaces
{
    public interface ISalesOrderService
    {
        Task CreateAsync(SalesOrderModel model);

        Task<SalesOrderModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<SalesOrderModel>> GetAllAsync();

        Task UpdateAsync(SalesOrderModel model);

        Task DeleteAsync(SalesOrderModel model);

    }
}