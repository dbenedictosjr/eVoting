﻿using OSPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Infrastructure.Interfaces
{
    public interface IModuleService
    {
        Task CreateAsync(ModuleModel module);

        Task<ModuleModel> GetByIdAsync(Guid? id);
        Task<IEnumerable<ModuleModel>> GetAllAsync();

        Task UpdateAsync(ModuleModel module);

        Task DeleteAsync(ModuleModel module);

    }
}