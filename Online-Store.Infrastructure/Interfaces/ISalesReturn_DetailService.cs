﻿using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Infrastructure.Interfaces
{
    public interface ISalesReturn_DetailService
    {
        Task CreateAsync(SalesReturn_DetailModel model);

        Task<SalesReturn_DetailModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<SalesReturn_DetailModel>> GetAllAsync();

        Task UpdateAsync(SalesReturn_DetailModel model);

        Task DeleteAsync(SalesReturn_DetailModel model);

    }
}