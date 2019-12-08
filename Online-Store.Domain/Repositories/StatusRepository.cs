using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class StatusRepository : Repository<StatusEntity>, IStatusRepository
    {
        public StatusRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
