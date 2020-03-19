using OSPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Infrastructure.Interfaces
{
    public interface IElectionService
    {
        Task CreateAsync(ElectionModel election);

        Task<ElectionModel> GetByIdAsync(Guid? id);
        Task<IEnumerable<ElectionModel>> GetAllAsync();
        Task<List<CPositionModel>> GetByMemberIdAsync(Guid? ballotId, Guid? memberId);

        Task UpdateAsync(ElectionModel election);

        Task DeleteAsync(ElectionModel election);

        Task SaveElection(ElectionModel election, List<CPositionModel> positions);

        Task<List<CPositionModel>> GetAllPositionAsync(Guid? ballotId, string status);
    }
}