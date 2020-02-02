using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Repositories
{
    public class MemberRepository : Repository<MemberEntity>, IMemberRepository
    {
        public MemberRepository(ApplicationDbContext _context) 
            : base(_context)
        {           
        }
    }
}
