﻿using System.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace System.Domain.Interfaces
{
    public interface ICandidateRepository : IRepository<CandidateEntity>
    {
        Task<IEnumerable<CandidateEntity>> GetAllByNomineeIdAsync(Guid? id);
    }
}