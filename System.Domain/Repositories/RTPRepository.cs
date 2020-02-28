using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class RTPRepository : Repository<RTPEntity>, IRTPRepository
    {
        public RTPRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
