using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class PositionRepository : Repository<PositionEntity>, IPositionRepository
    {
        public PositionRepository(ApplicationDbContext _context) 
            : base(_context)
        {           
        }
    }
}
