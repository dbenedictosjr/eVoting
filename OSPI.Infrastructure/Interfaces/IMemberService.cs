using OSPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Infrastructure.Interfaces
{
    public interface IMemberService
    {
        Task CreateAsync(MemberModel model);

        Task<MemberModel> GetByIDAsync(Guid? id);
        Task<MemberModel> GetByCodeAsync(string code);
        Task<IEnumerable<MemberModel>> GetAllAsync();

        Task UpdateAsync(MemberModel model);

        Task DeleteAsync(MemberModel model);

    }
}