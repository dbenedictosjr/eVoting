using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface IBillingService
    {
        Task CreateAsync(BillingModel model);

        Task<BillingModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<BillingModel>> GetAllAsync();

        Task UpdateAsync(BillingModel model);

        Task DeleteAsync(BillingModel model);

    }
}