using OSPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Infrastructure.Interfaces
{
    public interface IBallotService
    {
        Task CreateAsync(BallotModel ballot);

        Task<BallotModel> GetByIdAsync(Guid? id);
        Task<IEnumerable<BallotModel>> GetAllAsync();

        Task UpdateAsync(BallotModel ballot);

        Task DeleteAsync(BallotModel ballot);

        Task CloseNomination(Guid? id);
    }
}