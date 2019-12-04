using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;

namespace Online_Store.Domain.Repositories
{
    public class DeletedRecordsRepository : Repository<DeletedRecordsEntity>, IDeletedRecordsRepository
    {
        public DeletedRecordsRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
