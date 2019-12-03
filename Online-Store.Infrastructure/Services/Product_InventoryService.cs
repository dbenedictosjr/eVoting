using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;
using Online_Store.Infrastructure.Interfaces;
using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;

namespace Online_Store.Infrastructure.Services
{ }
    public class Product_InventoryService : IProduct_InventoryService
    {
        private readonly IProduct_InventoryRepository Product_Inventory;
    private readonly IMapper _mapper;

    public Product_InventoryService(IProduct_InventoryRepository reposity, IMapper mapper)
    {
        Product_Inventory = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(Product_InventoryModel model)
    {
        Product_Inventory.Create(_mapper.Map<Product_InventoryEntity>(model));
        await Product_Inventory.SaveAsync();
    }

    public async Task DeleteAsync(Product_InventoryModel model)
    {
        Product_Inventory.Delete(_mapper.Map<Product_InventoryEntity>(model));
        await Product_Inventory.SaveAsync();
    }

    public async Task<IEnumerable<Product_InventoryModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<Product_InventoryModel>>(await Product_Inventory.GetAllAsync());

    public async Task<Product_InventoryModel> GetByIDAsync(Guid? id)
        => _mapper.Map<Product_InventoryModel>(await Product_Inventory.GetByIDAsync(id));

    public async Task UpdateAsync(Product_InventoryModel model)
    {
        Product_Inventory.Update(_mapper.Map<Product_InventoryEntity>(model));
        await Product_Inventory.SaveAsync();
    }
}