using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface IShiftService
    {
        Task CreateAsync(ShiftModel model);

        Task<ShiftModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<ShiftModel>> GetAllAsync();

        Task UpdateAsync(ShiftModel model);

        Task DeleteAsync(ShiftModel model);

    }
}