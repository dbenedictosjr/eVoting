using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Inventory.Infrastructure.Interfaces
{
    public interface IReceivedOrderService
    {
        Task CreateAsync(ReceivedOrderModel model);

        Task<ReceivedOrderModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<ReceivedOrderModel>> GetAllAsync();

        Task UpdateAsync(ReceivedOrderModel model);

        Task DeleteAsync(ReceivedOrderModel model);

    }
}