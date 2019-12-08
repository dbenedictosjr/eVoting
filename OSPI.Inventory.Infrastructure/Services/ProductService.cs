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
    public class ProductService : IProductService
    {
        private readonly IProductRepository Product;
    private readonly IMapper _mapper;

    public ProductService(IProductRepository reposity, IMapper mapper)
    {
        Product = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(ProductModel model)
    {
        Product.Create(_mapper.Map<ProductEntity>(model));
        await Product.SaveAsync();
    }

    public async Task DeleteAsync(ProductModel model)
    {
        Product.Delete(_mapper.Map<ProductEntity>(model));
        await Product.SaveAsync();
    }

    public async Task<IEnumerable<ProductModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<ProductModel>>(await Product.GetAllAsync());

    public async Task<ProductModel> GetByIDAsync(Guid? id)
        => _mapper.Map<ProductModel>(await Product.GetByIDAsync(id));

    public async Task UpdateAsync(ProductModel model)
    {
        Product.Update(_mapper.Map<ProductEntity>(model));
        await Product.SaveAsync();
    }
}