using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Inventory.Infrastructure.Interfaces
{
    public interface IBilling_YieldingService
    {
        Task CreateAsync(Billing_YieldingModel model);

        Task<Billing_YieldingModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<Billing_YieldingModel>> GetAllAsync();

        Task UpdateAsync(Billing_YieldingModel model);

        Task DeleteAsync(Billing_YieldingModel model);

    }
}