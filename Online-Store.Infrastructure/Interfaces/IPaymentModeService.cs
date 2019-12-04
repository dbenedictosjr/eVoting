using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface IPaymentModeService
    {
        Task CreateAsync(PaymentModeModel model);

        Task<PaymentModeModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<PaymentModeModel>> GetAllAsync();

        Task UpdateAsync(PaymentModeModel model);

        Task DeleteAsync(PaymentModeModel model);

    }
}