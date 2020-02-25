using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class ReferencesRepository : Repository<ReferencesEntity>, IReferencesRepository
    {
        public ReferencesRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
