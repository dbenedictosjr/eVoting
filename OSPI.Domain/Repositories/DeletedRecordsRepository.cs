using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class DeletedRecordsRepository : Repository<DeletedRecordsEntity>, IdeletedRecordsRepository
    {
        public DeletedRecordsRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
