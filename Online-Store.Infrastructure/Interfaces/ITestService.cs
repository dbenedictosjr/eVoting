using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface ITestService
    {
        Task CreateAsync(TestModel model);

        Task<TestModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<TestModel>> GetAllAsync();

        Task UpdateAsync(TestModel model);

        Task DeleteAsync(TestModel model);

    }
}