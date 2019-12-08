using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class CustomerRepository : Repository<CustomerEntity>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
