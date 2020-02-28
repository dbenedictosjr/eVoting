using System.Data.Entity;
using System.Domain.Entities;
using System.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace System.Domain.Repositories
{
    public class PositionRepository : Repository<PositionEntity>, IPositionRepository
    {
        public PositionRepository(ApplicationDbContext context) 
            : base(context)
        {           
        }

        public override async Task<IEnumerable<PositionEntity>> GetAllAsync()
        {
            return await _context.Set<PositionEntity>()
            .Include(a => a.Election)
            .ToListAsync();
        }

        public override async Task<PositionEntity> GetByIdAsync(Guid? id) => await _context.Set<PositionEntity>()
            .Include(a => a.Election)
            .FirstOrDefaultAsync(a => a.PositionID == id);
    }
}
