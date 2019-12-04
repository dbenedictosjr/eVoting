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
    public class Product_YieldingService : IProduct_YieldingService
    {
        private readonly IProduct_YieldingRepository Product_Yielding;
    private readonly IMapper _mapper;

    public Product_YieldingService(IProduct_YieldingRepository reposity, IMapper mapper)
    {
        Product_Yielding = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(Product_YieldingModel model)
    {
        Product_Yielding.Create(_mapper.Map<Product_YieldingEntity>(model));
        await Product_Yielding.SaveAsync();
    }

    public async Task DeleteAsync(Product_YieldingModel model)
    {
        Product_Yielding.Delete(_mapper.Map<Product_YieldingEntity>(model));
        await Product_Yielding.SaveAsync();
    }

    public async Task<IEnumerable<Product_YieldingModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<Product_YieldingModel>>(await Product_Yielding.GetAllAsync());

    public async Task<Product_YieldingModel> GetByIDAsync(Guid? id)
        => _mapper.Map<Product_YieldingModel>(await Product_Yielding.GetByIDAsync(id));

    public async Task UpdateAsync(Product_YieldingModel model)
    {
        Product_Yielding.Update(_mapper.Map<Product_YieldingEntity>(model));
        await Product_Yielding.SaveAsync();
    }
}