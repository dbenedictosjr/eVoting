using System.Domain.Interfaces;
using System.Domain.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace System.Domain
{
    public class ApplicationDbContext : DbContext
    {
        public Guid CurrentUserId { get; set; }

        public DbSet<ModuleEntity> Modules { get; set; }

        public DbSet<RoleEntity> Roles { get; set; }

        public DbSet<RoleAccessEntity> RoleAccesses { get; set; }

        public DbSet<MemberEntity> Members { get; set; }

        public DbSet<ElectionEntity> Elections { get; set; }

        public DbSet<PositionEntity> Positions { get; set; }

        public DbSet<CandidateEntity> Candidates { get; set; }

        public DbSet<VoteEntity> Votes { get; set; }

        public DbSet<VoteDetailEntity> VoteDetails { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }
        public async Task<int> SaveChangesAsync()
        {
            UpdateAuditEntities();
            return await base.SaveChangesAsync();
        }

        private void UpdateAuditEntities()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entry in modifiedEntries)
            {
                var entity = (IAuditableEntity)entry.Entity;
                DateTime now = DateTime.UtcNow;

                if (entry.State == EntityState.Added)
                {
                    entity.CreatedDate = now;
                    entity.CreatedBy = CurrentUserId;
                }
                else
                {
                    base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                    base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
                }

                entity.UpdatedDate = now;
                entity.UpdatedBy = CurrentUserId;
            }
        }
    }
}
