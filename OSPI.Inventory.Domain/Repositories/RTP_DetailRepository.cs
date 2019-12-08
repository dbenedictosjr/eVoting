using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class RTP_DetailRepository : Repository<RTP_DetailEntity>, IRTP_DetailRepository
    {
        public RTP_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
