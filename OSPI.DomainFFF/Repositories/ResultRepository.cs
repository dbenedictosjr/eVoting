using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class ResultRepository : Repository<ResultEntity>, IResultRepository
    {
        public ResultRepository(ApplicationDbContext _context) 
            : base(_context)
        {           
        }
    }
}
