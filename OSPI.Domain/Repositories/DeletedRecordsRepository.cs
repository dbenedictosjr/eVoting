using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class DeletedRecordsRepository : Repository<DeletedRecordsEntity>, IDeletedRecordsRepository
    {
        public DeletedRecordsRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
