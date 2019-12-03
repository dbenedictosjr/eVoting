using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
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