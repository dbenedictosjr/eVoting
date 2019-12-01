using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface ICategory3Service
    {
        Task CreateAsync(Category3Model model);

        Task<Category3Model> GetByIDAsync(Guid? id);
        Task<IEnumerable<Category3Model>> GetAllAsync();

        Task UpdateAsync(Category3Model model);

        Task DeleteAsync(Category3Model model);

    }
}