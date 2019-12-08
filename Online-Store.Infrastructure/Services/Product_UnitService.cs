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
    public class Product_UnitService : IProduct_UnitService
    {
        private readonly IProduct_UnitRepository Product_Unit;
    private readonly IMapper _mapper;

    public Product_UnitService(IProduct_UnitRepository reposity, IMapper mapper)
    {
        Product_Unit = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(Product_UnitModel model)
    {
        Product_Unit.Create(_mapper.Map<Product_UnitEntity>(model));
        await Product_Unit.SaveAsync();
    }

    public async Task DeleteAsync(Product_UnitModel model)
    {
        Product_Unit.Delete(_mapper.Map<Product_UnitEntity>(model));
        await Product_Unit.SaveAsync();
    }

    public async Task<IEnumerable<Product_UnitModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<Product_UnitModel>>(await Product_Unit.GetAllAsync());

    public async Task<Product_UnitModel> GetByIDAsync(Guid? id)
        => _mapper.Map<Product_UnitModel>(await Product_Unit.GetByIDAsync(id));

    public async Task UpdateAsync(Product_UnitModel model)
    {
        Product_Unit.Update(_mapper.Map<Product_UnitEntity>(model));
        await Product_Unit.SaveAsync();
    }
}