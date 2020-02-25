using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class UOMRepository : Repository<UOMEntity>, IUOMRepository
    {
        public UOMRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
