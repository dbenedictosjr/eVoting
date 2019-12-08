using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class ShiftRepository : Repository<ShiftEntity>, IShiftRepository
    {
        public ShiftRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
