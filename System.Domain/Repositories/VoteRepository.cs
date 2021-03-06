﻿using System.Data.Entity;
using System.Domain.Entities;
using System.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace System.Domain.Repositories
{
    public class VoteRepository : Repository<VoteEntity>, IVoteRepository
    {
        public VoteRepository(ApplicationDbContext context) 
            : base(context)
        {
        }
        public override async Task<IEnumerable<VoteEntity>> GetAllAsync()
        {
            return await _context.Set<VoteEntity>()
            .Include(a => a.Member)
            .Include(a => a.Election)
            .ToListAsync();
        }

        public override async Task<VoteEntity> GetByIdAsync(Guid? id) => await _context.Set<VoteEntity>()
            .Include(a => a.Member)
            .Include(a => a.Election)
            .FirstOrDefaultAsync(a => a.VoteID == id);
    }
}
