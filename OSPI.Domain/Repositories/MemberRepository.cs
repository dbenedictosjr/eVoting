using Microsoft.EntityFrameworkCore;
using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Domain.Repositories
{
    public class MemberRepository : Repository<MemberEntity>, IMemberRepository
    {
        public MemberRepository(ApplicationDbContext context) 
            : base(context)
        {           
        }

        public override async Task<IEnumerable<MemberEntity>> GetAllAsync() => await _context.Set<MemberEntity>()
            .Include(a => a.Role)
            .ToListAsync();
    }
}
