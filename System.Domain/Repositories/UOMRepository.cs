using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class UOMRepository : Repository<UOMEntity>, IUOMRepository
    {
        public UOMRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
