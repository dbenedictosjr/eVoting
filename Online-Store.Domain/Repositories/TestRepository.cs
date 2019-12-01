using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class TestRepository : Repository<TestEntity>, ITestRepository
    {
        public TestRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
