using OSPI.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Domain.Interfaces
{
    public interface IMemberRepository : IRepository<MemberEntity>
    {
        Task<MemberEntity> GetByCodeAsync(string code);
        Task<IEnumerable<MemberEntity>> GetAllVotersAsync();

    }
}
