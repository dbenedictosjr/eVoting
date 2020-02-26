using OSPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Infrastructure.Interfaces
{
    public interface ICandidateService
    {
        Task CreateAsync(CandidateModel candidate);

        Task<CandidateModel> GetByIdAsync(Guid? id);
        Task<IEnumerable<CandidateModel>> GetAllByNomineeIdAsync(Guid? id);

        Task<IEnumerable<CandidateModel>> GetAllAsync();

        Task UpdateAsync(CandidateModel candidate);

        Task DeleteAsync(CandidateModel candidate);

    }
}