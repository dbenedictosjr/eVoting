using Microsoft.EntityFrameworkCore;
using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Domain.Repositories
{
    public class CandidateRepository : Repository<CandidateEntity>, ICandidateRepository
    {
        public CandidateRepository(ApplicationDbContext context) 
            : base(context)
        {
        }
        public override async Task<IEnumerable<CandidateEntity>> GetAllAsync()
        {
            return await _context.Set<CandidateEntity>()
            .Include(a => a.Position)
            .Include(a => a.CandidateMember)
            .Include(a => a.NomineeMember)
            .ToListAsync();
        }

        public override async Task<CandidateEntity> GetByIDAsync(Guid? id) => await _context.Set<CandidateEntity>()
            .Include(a => a.Position)
            .Include(a => a.CandidateMember)
            .Include(a => a.NomineeMember)
            .FirstOrDefaultAsync(a => a.CandidateID == id);

    }
}
