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
    public class Product_InventoryEntryService : IProduct_InventoryEntryService
    {
        private readonly IProduct_InventoryEntryRepository Product_InventoryEntry;
    private readonly IMapper _mapper;

    public Product_InventoryEntryService(IProduct_InventoryEntryRepository reposity, IMapper mapper)
    {
        Product_InventoryEntry = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(Product_InventoryEntryModel model)
    {
        Product_InventoryEntry.Create(_mapper.Map<Product_InventoryEntryEntity>(model));
        await Product_InventoryEntry.SaveAsync();
    }

    public async Task DeleteAsync(Product_InventoryEntryModel model)
    {
        Product_InventoryEntry.Delete(_mapper.Map<Product_InventoryEntryEntity>(model));
        await Product_InventoryEntry.SaveAsync();
    }

    public async Task<IEnumerable<Product_InventoryEntryModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<Product_InventoryEntryModel>>(await Product_InventoryEntry.GetAllAsync());

    public async Task<Product_InventoryEntryModel> GetByIDAsync(Guid? id)
        => _mapper.Map<Product_InventoryEntryModel>(await Product_InventoryEntry.GetByIDAsync(id));

    public async Task UpdateAsync(Product_InventoryEntryModel model)
    {
        Product_InventoryEntry.Update(_mapper.Map<Product_InventoryEntryEntity>(model));
        await Product_InventoryEntry.SaveAsync();
    }
}