using OSPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Infrastructure.Interfaces
{
    public interface IBallotService
    {
        Task CreateAsync(BallotModel model);

        Task<BallotModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<BallotModel>> GetAllAsync();

        Task UpdateAsync(BallotModel model);

        Task DeleteAsync(BallotModel model);

    }
}