using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Inventory.Infrastructure.Interfaces
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