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
    public class ProductParStockService : IProductParStockService
    {
        private readonly IProductParStockRepository ProductParStock;
    private readonly IMapper _mapper;

    public ProductParStockService(IProductParStockRepository reposity, IMapper mapper)
    {
        ProductParStock = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(ProductParStockModel model)
    {
        ProductParStock.Create(_mapper.Map<ProductParStockEntity>(model));
        await ProductParStock.SaveAsync();
    }

    public async Task DeleteAsync(ProductParStockModel model)
    {
        ProductParStock.Delete(_mapper.Map<ProductParStockEntity>(model));
        await ProductParStock.SaveAsync();
    }

    public async Task<IEnumerable<ProductParStockModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<ProductParStockModel>>(await ProductParStock.GetAllAsync());

    public async Task<ProductParStockModel> GetByIDAsync(Guid? id)
        => _mapper.Map<ProductParStockModel>(await ProductParStock.GetByIDAsync(id));

    public async Task UpdateAsync(ProductParStockModel model)
    {
        ProductParStock.Update(_mapper.Map<ProductParStockEntity>(model));
        await ProductParStock.SaveAsync();
    }
}