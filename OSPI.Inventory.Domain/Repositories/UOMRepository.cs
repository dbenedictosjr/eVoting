using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class UOMRepository : Repository<UOMEntity>, IUOMRepository
    {
        public UOMRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
