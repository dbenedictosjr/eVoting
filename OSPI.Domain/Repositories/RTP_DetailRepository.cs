using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class RTP_DetailRepository : Repository<RTP_DetailEntity>, IRTP_DetailRepository
    {
        public RTP_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
