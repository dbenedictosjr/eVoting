using System.Domain.Entities;
using System.Threading.Tasks;

namespace System.Domain.Interfaces
{
    public interface IMemberRepository : IRepository<MemberEntity>
    {
        Task<MemberEntity> GetByCodeAsync(string code);
    }
}
