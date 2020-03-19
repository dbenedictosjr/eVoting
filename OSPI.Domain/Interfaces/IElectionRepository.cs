using OSPI.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace OSPI.Domain.Interfaces
{
    public interface IElectionRepository : IRepository<ElectionEntity>
    {
        Task<ElectionEntity> GetByMemberAndPositionAsync(Guid? ballotId, Guid? memberId);
    }
}
