using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface ISupplierService
    {
        Task CreateAsync(SupplierModel model);

        Task<SupplierModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<SupplierModel>> GetAllAsync();

        Task UpdateAsync(SupplierModel model);

        Task DeleteAsync(SupplierModel model);

    }
}