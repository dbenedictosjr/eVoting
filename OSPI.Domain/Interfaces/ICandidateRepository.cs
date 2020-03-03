using OSPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Domain.Interfaces
{
    public interface ICandidateRepository : IRepository<CandidateEntity>
    {
        Task<IEnumerable<CandidateEntity>> GetAllByNomineeIdAsync(Guid? id);
        Task<IEnumerable<CandidateEntity>> GetAllCandidatesAsync(Guid? id, string status);
        Task<IEnumerable<CandidateEntity>> GetAllByPositionIdAsync(Guid? id, string status);
    }
}