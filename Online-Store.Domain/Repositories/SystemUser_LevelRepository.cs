using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class SystemUser_LevelRepository : Repository<SystemUser_LevelEntity>, ISystemUser_LevelRepository
    {
        public SystemUser_LevelRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
