using System.Data.Entity;
using System.Domain.Entities;
using System.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System.Domain.Repositories
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

        public override async Task<CandidateEntity> GetByIdAsync(Guid? id) => await _context.Set<CandidateEntity>()
            .Include(a => a.Position)
            .Include(a => a.CandidateMember)
            .Include(a => a.NomineeMember)
            .FirstOrDefaultAsync(a => a.CandidateID == id);

        public async Task<IEnumerable<CandidateEntity>> GetAllByNomineeIdAsync(Guid? id)
        {
            return await _context.Set<CandidateEntity>()
            .Include(a => a.Position)
            .Include(a => a.CandidateMember)
            .Include(a => a.NomineeMember)
            .Where(a => a.NomineeMemberID == id)
            .ToListAsync();
        }
    }
}