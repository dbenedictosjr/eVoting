﻿using Microsoft.EntityFrameworkCore;
using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSPI.Domain.Repositories
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
            .Include(a => a.Ballot)
            .ToListAsync();
        }

        public async Task<IEnumerable<PositionEntity>> GetAllByBallotIdAsync(Guid? id)
        {
            return await _context.Set<PositionEntity>()
            .Where(a => a.BallotId == id)
            .ToListAsync();
        }

        public override async Task<PositionEntity> GetByIdAsync(Guid? id) => await _context.Set<PositionEntity>()
            .Include(a => a.Ballot)
            .FirstOrDefaultAsync(a => a.PositionId == id);
    }
}