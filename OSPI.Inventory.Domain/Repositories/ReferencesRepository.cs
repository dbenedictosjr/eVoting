using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class ReferencesRepository : Repository<ReferencesEntity>, IReferencesRepository
    {
        public ReferencesRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
