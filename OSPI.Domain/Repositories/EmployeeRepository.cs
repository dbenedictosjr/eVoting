using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class EmployeeRepository : Repository<EmployeeEntity>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
