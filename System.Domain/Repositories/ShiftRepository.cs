using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class ShiftRepository : Repository<ShiftEntity>, IShiftRepository
    {
        public ShiftRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
