using Microsoft.EntityFrameworkCore;
using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public override async Task<CandidateEntity> GetByIdAsync(Guid? id) => await _context.Set<CandidateEntity>()
            .Include(a => a.Position)
            .Include(a => a.CandidateMember)
            .Include(a => a.NomineeMember)
            .FirstOrDefaultAsync(a => a.CandidateId == id);

        public async Task<IEnumerable<CandidateEntity>> GetAllByNomineeIdAsync(Guid? id)
        {
            return await _context.Set<CandidateEntity>()
            .Include(a => a.Position)
            .Include(a => a.CandidateMember)
            .Include(a => a.NomineeMember)
            .Where(a => a.NomineeMemberId == id)
            .ToListAsync();
        }
        public async Task<IEnumerable<CandidateEntity>> GetAllCandidatesAsync(Guid? id, string status)
        {
            return await _context.Set<CandidateEntity>()
            .Include(a => a.Position)
            .Include(a => a.CandidateMember)
            .Include(a => a.NomineeMember)
            .Where(a => a.Position.BallotId == id)
            .Where(a => a.Status == status)
            .OrderBy(a => a.PositionId)
            .ToListAsync();
        }

        public async Task<IEnumerable<CandidateEntity>> GetAllByPositionIdAsync(Guid? id, string status)
        {
            return await _context.Set<CandidateEntity>()
            .Include(a => a.Position)
            .Include(a => a.CandidateMember)
            .Include(a => a.NomineeMember)
            .Where(a => a.Status == status)
            .Where(a => a.PositionId == id)
            .OrderBy(a => a.PositionId)
            .ToListAsync();
        }
    }
}