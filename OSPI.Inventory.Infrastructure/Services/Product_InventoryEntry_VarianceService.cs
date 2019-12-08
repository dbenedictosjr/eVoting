using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;
using OSPI.Inventory.Infrastructure.Interfaces;
using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;

namespace OSPI.Inventory.Infrastructure.Services
{ }
    public class Product_InventoryEntry_VarianceService : IProduct_InventoryEntry_VarianceService
    {
        private readonly IProduct_InventoryEntry_VarianceRepository Product_InventoryEntry_Variance;
    private readonly IMapper _mapper;

    public Product_InventoryEntry_VarianceService(IProduct_InventoryEntry_VarianceRepository reposity, IMapper mapper)
    {
        Product_InventoryEntry_Variance = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(Product_InventoryEntry_VarianceModel model)
    {
        Product_InventoryEntry_Variance.Create(_mapper.Map<Product_InventoryEntry_VarianceEntity>(model));
        await Product_InventoryEntry_Variance.SaveAsync();
    }

    public async Task DeleteAsync(Product_InventoryEntry_VarianceModel model)
    {
        Product_InventoryEntry_Variance.Delete(_mapper.Map<Product_InventoryEntry_VarianceEntity>(model));
        await Product_InventoryEntry_Variance.SaveAsync();
    }

    public async Task<IEnumerable<Product_InventoryEntry_VarianceModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<Product_InventoryEntry_VarianceModel>>(await Product_InventoryEntry_Variance.GetAllAsync());

    public async Task<Product_InventoryEntry_VarianceModel> GetByIDAsync(Guid? id)
        => _mapper.Map<Product_InventoryEntry_VarianceModel>(await Product_InventoryEntry_Variance.GetByIDAsync(id));

    public async Task UpdateAsync(Product_InventoryEntry_VarianceModel model)
    {
        Product_InventoryEntry_Variance.Update(_mapper.Map<Product_InventoryEntry_VarianceEntity>(model));
        await Product_InventoryEntry_Variance.SaveAsync();
    }
}