using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Inventory.Infrastructure.Interfaces
{
    public interface IUOMService
    {
        Task CreateAsync(UOMModel model);

        Task<UOMModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<UOMModel>> GetAllAsync();

        Task UpdateAsync(UOMModel model);

        Task DeleteAsync(UOMModel model);

    }
}