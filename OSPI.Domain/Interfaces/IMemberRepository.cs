using OSPI.Domain.Entities;
using System.Threading.Tasks;

namespace OSPI.Domain.Interfaces
{
    public interface IMemberRepository : IRepository<MemberEntity>
    {
        Task<MemberEntity> GetByCodeAsync(string code);
    }
}
