using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface IRTP_DetailService
    {
        Task CreateAsync(RTP_DetailModel model);

        Task<RTP_DetailModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<RTP_DetailModel>> GetAllAsync();

        Task UpdateAsync(RTP_DetailModel model);

        Task DeleteAsync(RTP_DetailModel model);

    }
}