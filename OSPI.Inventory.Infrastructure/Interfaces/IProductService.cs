﻿using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Inventory.Infrastructure.Interfaces
{
    public interface IProductService
    {
        Task CreateAsync(ProductModel model);

        Task<ProductModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<ProductModel>> GetAllAsync();

        Task UpdateAsync(ProductModel model);

        Task DeleteAsync(ProductModel model);

    }
}