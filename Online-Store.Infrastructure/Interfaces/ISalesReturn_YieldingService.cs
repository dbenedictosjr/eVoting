using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface ISalesReturn_YieldingService
    {
        Task CreateAsync(SalesReturn_YieldingModel model);

        Task<SalesReturn_YieldingModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<SalesReturn_YieldingModel>> GetAllAsync();

        Task UpdateAsync(SalesReturn_YieldingModel model);

        Task DeleteAsync(SalesReturn_YieldingModel model);

    }
}