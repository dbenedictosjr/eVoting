using OSPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Infrastructure.Interfaces
{
    public interface IBulletinService
    {
        Task CreateAsync(BulletinModel bulletin);

        Task<BulletinModel> GetByIdAsync(Guid? bulletinId);
        Task<IEnumerable<BulletinModel>> GetAllAsync();

        Task UpdateAsync(BulletinModel bulletin);

        Task DeleteAsync(BulletinModel bulletin);

    }
}