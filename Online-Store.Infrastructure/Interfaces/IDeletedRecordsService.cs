using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface IDeletedRecordsService
    {
        Task CreateAsync(DeletedRecordsModel model);

        Task<DeletedRecordsModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<DeletedRecordsModel>> GetAllAsync();

        Task UpdateAsync(DeletedRecordsModel model);

        Task DeleteAsync(DeletedRecordsModel model);

    }
}