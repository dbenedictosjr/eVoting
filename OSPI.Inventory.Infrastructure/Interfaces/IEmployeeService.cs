using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Inventory.Infrastructure.Interfaces
{
    public interface IEmployeeService
    {
        Task CreateAsync(EmployeeModel model);

        Task<EmployeeModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<EmployeeModel>> GetAllAsync();

        Task UpdateAsync(EmployeeModel model);

        Task DeleteAsync(EmployeeModel model);

    }
}