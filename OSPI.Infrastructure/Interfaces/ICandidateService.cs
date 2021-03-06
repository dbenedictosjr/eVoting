﻿using OSPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Infrastructure.Interfaces
{
    public interface ICandidateService
    {
        Task CreateAsync(CandidateModel candidate);

        Task UpdateAsync(CandidateModel candidate);
        Task UpdateStatusAsync(Guid id, string status);

        Task DeleteAsync(CandidateModel candidate);

        Task<CandidateModel> GetByIdAsync(Guid? id);
        Task<IEnumerable<CandidateModel>> GetAllByNomineeIdAsync(Guid? id);
        Task<IEnumerable<CandidateModel>> GetAllCandidatesAsync(Guid? ballotId, string status);
        Task<IEnumerable<CandidateModel>> GetAllByPositionIdAsync(Guid? positionId, string status);
        Task<List<CPositionModel>> GetAllPositionAsync(Guid? ballotId, string status);
        Task<IEnumerable<CandidateModel>> GetAllAsync();
    }
}