using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class GiftCheckRepository : Repository<GiftCheckEntity>, IGiftCheckRepository
    {
        public GiftCheckRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
