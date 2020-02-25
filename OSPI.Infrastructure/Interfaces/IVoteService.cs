using OSPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Infrastructure.Interfaces
{
    public interface IVoteService
    {
        Task CreateAsync(VoteModel vote);

        Task<VoteModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<VoteModel>> GetAllAsync();

        Task UpdateAsync(VoteModel vote);

        Task DeleteAsync(VoteModel vote);

    }
}