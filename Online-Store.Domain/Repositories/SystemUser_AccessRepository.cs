using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class SystemUser_AccessRepository : Repository<SystemUser_AccessEntity>, ISystemUser_AccessRepository
    {
        public SystemUser_AccessRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
