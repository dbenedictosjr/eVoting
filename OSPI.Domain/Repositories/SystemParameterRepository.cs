using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class SystemParameterRepository : Repository<SystemParameterEntity>, ISystemParameterRepository
    {
        public SystemParameterRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
