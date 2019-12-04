using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class RTP_DetailRepository : Repository<RTP_DetailEntity>, IRTP_DetailRepository
    {
        public RTP_DetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
