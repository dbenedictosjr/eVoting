using OSPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Infrastructure.Interfaces
{
    public interface IMemberService
    {
        Task CreateAsync(MemberModel member);

        Task<MemberModel> GetByIdAsync(Guid? id);
        Task<MemberModel> GetByCodeAsync(string code);
        Task<IEnumerable<MemberModel>> GetAllAsync();

        Task UpdateAsync(MemberModel member);

        Task DeleteAsync(MemberModel member);

    }
}