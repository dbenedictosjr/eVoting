using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class EmployeeRepository : Repository<EmployeeEntity>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
