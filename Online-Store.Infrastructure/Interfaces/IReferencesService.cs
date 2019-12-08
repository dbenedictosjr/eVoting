using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface IReferencesService
    {
        Task CreateAsync(ReferencesModel model);

        Task<ReferencesModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<ReferencesModel>> GetAllAsync();

        Task UpdateAsync(ReferencesModel model);

        Task DeleteAsync(ReferencesModel model);

    }
}