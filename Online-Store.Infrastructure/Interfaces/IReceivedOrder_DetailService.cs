using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface IReceivedOrder_DetailService
    {
        Task CreateAsync(ReceivedOrder_DetailModel model);

        Task<ReceivedOrder_DetailModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<ReceivedOrder_DetailModel>> GetAllAsync();

        Task UpdateAsync(ReceivedOrder_DetailModel model);

        Task DeleteAsync(ReceivedOrder_DetailModel model);

    }
}