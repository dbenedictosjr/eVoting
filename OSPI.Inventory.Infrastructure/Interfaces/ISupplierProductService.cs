using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Inventory.Infrastructure.Interfaces
{
    public interface ISupplierProductService
    {
        Task CreateAsync(SupplierProductModel model);

        Task<SupplierProductModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<SupplierProductModel>> GetAllAsync();

        Task UpdateAsync(SupplierProductModel model);

        Task DeleteAsync(SupplierProductModel model);

    }
}