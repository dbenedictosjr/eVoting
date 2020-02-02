using OSPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Infrastructure.Interfaces
{
    public interface IResultService
    {
        Task CreateAsync(ResultModel model);

        Task<ResultModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<ResultModel>> GetAllAsync();

        Task UpdateAsync(ResultModel model);

        Task DeleteAsync(ResultModel model);

    }
}