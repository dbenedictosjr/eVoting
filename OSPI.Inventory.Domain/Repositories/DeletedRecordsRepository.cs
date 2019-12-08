using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;

namespace OSPI.Inventory.Domain.Repositories
{
    public class DeletedRecordsRepository : Repository<DeletedRecordsEntity>, IDeletedRecordsRepository
    {
        public DeletedRecordsRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
