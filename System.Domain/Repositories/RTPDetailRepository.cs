using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class RTPDetailRepository : Repository<RTPDetailEntity>, IRTPDetailRepository
    {
        public RTPDetailRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
