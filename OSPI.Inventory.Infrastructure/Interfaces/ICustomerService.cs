using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Inventory.Infrastructure.Interfaces
{
    public interface ICustomerService
    {
        Task CreateAsync(CustomerModel model);

        Task<CustomerModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<CustomerModel>> GetAllAsync();

        Task UpdateAsync(CustomerModel model);

        Task DeleteAsync(CustomerModel model);

    }
}