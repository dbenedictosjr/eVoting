using OSPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Infrastructure.Interfaces
{
    public interface IElectionDetailService
    {
        Task CreateAsync(ElectionDetailModel electionDetail);

        Task<ElectionDetailModel> GetByIdAsync(Guid? id);
        Task<IEnumerable<ElectionDetailModel>> GetAllAsync();

        Task UpdateAsync(ElectionDetailModel electionDetail);

        Task DeleteAsync(ElectionDetailModel electionDetail);

    }
}