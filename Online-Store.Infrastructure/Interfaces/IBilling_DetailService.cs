using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface IBilling_DetailService
    {
        Task CreateAsync(Billing_DetailModel model);

        Task<Billing_DetailModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<Billing_DetailModel>> GetAllAsync();

        Task UpdateAsync(Billing_DetailModel model);

        Task DeleteAsync(Billing_DetailModel model);

    }
}