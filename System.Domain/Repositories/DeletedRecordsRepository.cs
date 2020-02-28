using System.Domain.Entities;
using System.Domain.Interfaces;

namespace System.Domain.Repositories
{
    public class DeletedRecordsRepository : Repository<DeletedRecordsEntity>, IDeletedRecordsRepository
    {
        public DeletedRecordsRepository(ApplicationDbContext _context)
            : base(_context)
        {

        }
    }
}
