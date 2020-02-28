using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class StatusRepository : Repository<StatusEntity>, IStatusRepository
    {
        public StatusRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
