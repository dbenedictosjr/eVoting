using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class SystemParameterRepository : Repository<SystemParameterEntity>, ISystemParameterRepository
    {
        public SystemParameterRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
