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
    public class Product_InventoryEntry_DetailService : IProduct_InventoryEntry_DetailService
    {
        private readonly IProduct_InventoryEntry_DetailRepository Product_InventoryEntry_Detail;
    private readonly IMapper _mapper;

    public Product_InventoryEntry_DetailService(IProduct_InventoryEntry_DetailRepository reposity, IMapper mapper)
    {
        Product_InventoryEntry_Detail = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(Product_InventoryEntry_DetailModel model)
    {
        Product_InventoryEntry_Detail.Create(_mapper.Map<Product_InventoryEntry_DetailEntity>(model));
        await Product_InventoryEntry_Detail.SaveAsync();
    }

    public async Task DeleteAsync(Product_InventoryEntry_DetailModel model)
    {
        Product_InventoryEntry_Detail.Delete(_mapper.Map<Product_InventoryEntry_DetailEntity>(model));
        await Product_InventoryEntry_Detail.SaveAsync();
    }

    public async Task<IEnumerable<Product_InventoryEntry_DetailModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<Product_InventoryEntry_DetailModel>>(await Product_InventoryEntry_Detail.GetAllAsync());

    public async Task<Product_InventoryEntry_DetailModel> GetByIDAsync(Guid? id)
        => _mapper.Map<Product_InventoryEntry_DetailModel>(await Product_InventoryEntry_Detail.GetByIDAsync(id));

    public async Task UpdateAsync(Product_InventoryEntry_DetailModel model)
    {
        Product_InventoryEntry_Detail.Update(_mapper.Map<Product_InventoryEntry_DetailEntity>(model));
        await Product_InventoryEntry_Detail.SaveAsync();
    }
}