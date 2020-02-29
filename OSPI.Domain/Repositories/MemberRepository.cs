using Microsoft.EntityFrameworkCore;
using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;
using System;
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

        public override async Task<IEnumerable<MemberEntity>> GetAllAsync()
        {
            return await _context.Set<MemberEntity>()
            .Include(a => a.Role)
            .ToListAsync();
        }

        public override async Task<MemberEntity> GetByIdAsync(Guid? id) => await _context.Set<MemberEntity>()
            .Include(a => a.Role)
            .FirstOrDefaultAsync(a => a.MemberId == id);

        public async Task<MemberEntity> GetByCodeAsync(string code) => await _context.Set<MemberEntity>()
            .Include(a => a.Role)
            .FirstOrDefaultAsync(a => a.MemberNo == code);
    }
}
