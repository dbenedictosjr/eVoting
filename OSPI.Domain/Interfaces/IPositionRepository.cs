using OSPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Domain.Interfaces
{
    public interface IPositionRepository : IRepository<PositionEntity>
    {
        Task<IEnumerable<PositionEntity>> GetAllByElectionIdAsync(Guid? id);
    }
}