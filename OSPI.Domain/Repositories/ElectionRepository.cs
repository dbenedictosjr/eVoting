using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class ElectionRepository : Repository<ElectionEntity>, IElectionRepository
    {
        public ElectionRepository(ApplicationDbContext context) 
            : base(context)
        {           
        }
    }
}
