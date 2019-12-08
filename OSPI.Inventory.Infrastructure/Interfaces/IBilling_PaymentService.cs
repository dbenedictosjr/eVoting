using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Inventory.Infrastructure.Interfaces
{
    public interface IBilling_PaymentService
    {
        Task CreateAsync(Billing_PaymentModel model);

        Task<Billing_PaymentModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<Billing_PaymentModel>> GetAllAsync();

        Task UpdateAsync(Billing_PaymentModel model);

        Task DeleteAsync(Billing_PaymentModel model);

    }
}