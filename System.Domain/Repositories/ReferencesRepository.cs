using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class ReferencesRepository : Repository<ReferencesEntity>, IReferencesRepository
    {
        public ReferencesRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
