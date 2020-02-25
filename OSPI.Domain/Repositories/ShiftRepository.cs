using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class ShiftRepository : Repository<ShiftEntity>, IShiftRepository
    {
        public ShiftRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
