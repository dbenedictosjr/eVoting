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
    public class ProductParStock_DetailService : IProductParStock_DetailService
    {
        private readonly IProductParStock_DetailRepository ProductParStock_Detail;
    private readonly IMapper _mapper;

    public ProductParStock_DetailService(IProductParStock_DetailRepository reposity, IMapper mapper)
    {
        ProductParStock_Detail = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(ProductParStock_DetailModel model)
    {
        ProductParStock_Detail.Create(_mapper.Map<ProductParStock_DetailEntity>(model));
        await ProductParStock_Detail.SaveAsync();
    }

    public async Task DeleteAsync(ProductParStock_DetailModel model)
    {
        ProductParStock_Detail.Delete(_mapper.Map<ProductParStock_DetailEntity>(model));
        await ProductParStock_Detail.SaveAsync();
    }

    public async Task<IEnumerable<ProductParStock_DetailModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<ProductParStock_DetailModel>>(await ProductParStock_Detail.GetAllAsync());

    public async Task<ProductParStock_DetailModel> GetByIDAsync(Guid? id)
        => _mapper.Map<ProductParStock_DetailModel>(await ProductParStock_Detail.GetByIDAsync(id));

    public async Task UpdateAsync(ProductParStock_DetailModel model)
    {
        ProductParStock_Detail.Update(_mapper.Map<ProductParStock_DetailEntity>(model));
        await ProductParStock_Detail.SaveAsync();
    }
}