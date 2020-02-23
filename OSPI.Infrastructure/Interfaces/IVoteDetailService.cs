using OSPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Infrastructure.Interfaces
{
    public interface IVoteDetailService
    {
        Task CreateAsync(VoteDetailModel model);

        Task<VoteDetailModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<VoteDetailModel>> GetAllAsync();

        Task UpdateAsync(VoteDetailModel model);

        Task DeleteAsync(VoteDetailModel model);

    }
}