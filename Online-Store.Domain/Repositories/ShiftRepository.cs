using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class ShiftRepository : Repository<ShiftEntity>, IShiftRepository
    {
        public ShiftRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
