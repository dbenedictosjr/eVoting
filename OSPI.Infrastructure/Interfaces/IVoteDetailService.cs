using OSPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Infrastructure.Interfaces
{
    public interface IVoteDetailService
    {
        Task CreateAsync(VoteDetailModel voteDetail);

        Task<VoteDetailModel> GetByIdAsync(Guid? id);
        Task<IEnumerable<VoteDetailModel>> GetAllAsync();

        Task UpdateAsync(VoteDetailModel voteDetail);

        Task DeleteAsync(VoteDetailModel voteDetail);

    }
}