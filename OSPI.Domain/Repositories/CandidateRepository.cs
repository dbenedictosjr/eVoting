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
            .Include(a => a.Votes)
            .ToListAsync();
        }

        public override async Task<CandidateEntity> GetByIdAsync(Guid? id) => await _context.Set<CandidateEntity>()
            .Include(a => a.Position)
            .Include(a => a.CandidateMember)
            .Include(a => a.NomineeMember)
            .Include(a => a.Votes).ThenInclude(a => a.Election).ThenInclude(a => a.Member)
            .FirstOrDefaultAsync(a => a.CandidateId == id);

        public async Task<IEnumerable<CandidateEntity>> GetAllByNomineeIdAsync(Guid? id)
        {
            return await _context.Set<CandidateEntity>()
            .Include(a => a.Position)
            .Include(a => a.CandidateMember)
            .Include(a => a.NomineeMember)
            .Where(a => a.NomineeMemberId == id)
            .Include(a => a.Votes)
            .ToListAsync();
        }
        public async Task<IEnumerable<CandidateEntity>> GetAllCandidatesAsync(Guid? ballotId, string status)
        {
            return await _context.Set<CandidateEntity>()
            .Include(a => a.Position)
            .Include(a => a.CandidateMember)
            .Include(a => a.NomineeMember)
            .Include(a => a.Votes)
            .Where(a => a.Position.BallotId == ballotId)
            .Where(a => a.Status == status)
            .OrderBy(a => a.PositionId)
            .ToListAsync();
        }

        public async Task<IEnumerable<CandidateEntity>> GetAllByPositionIdAsync(Guid? positionId, string status)
        {
            return await _context.Set<CandidateEntity>()
            .Include(a => a.Position)
            .Include(a => a.CandidateMember)
            .Include(a => a.NomineeMember)
            .Include(a => a.Votes)
            .Where(a => a.PositionId == positionId)
            .Where(a => a.Status == status)
            .OrderBy(a => a.PositionId)
            .ToListAsync();
        }

        public async Task<IEnumerable<CandidateEntity>> GetAllCandidatesAsync(Guid? ballotId, Guid? positionId, string status)
        {
            return await _context.Set<CandidateEntity>()
            .Include(a => a.Position)
            .Include(a => a.CandidateMember)
            .Include(a => a.NomineeMember)
            .Include(a => a.Votes)
            .Where(a => a.Position.BallotId == ballotId)
            .Where(a => a.PositionId == positionId)
            .Where(a => a.Status == status)
            .OrderBy(a => a.PositionId)
            .ToListAsync();
        }
    }
}