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
    public class PurchaseReturn_DetailService : IPurchaseReturn_DetailService
    {
        private readonly IPurchaseReturn_DetailRepository PurchaseReturn_Detail;
    private readonly IMapper _mapper;

    public PurchaseReturn_DetailService(IPurchaseReturn_DetailRepository reposity, IMapper mapper)
    {
        PurchaseReturn_Detail = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(PurchaseReturn_DetailModel model)
    {
        PurchaseReturn_Detail.Create(_mapper.Map<PurchaseReturn_DetailEntity>(model));
        await PurchaseReturn_Detail.SaveAsync();
    }

    public async Task DeleteAsync(PurchaseReturn_DetailModel model)
    {
        PurchaseReturn_Detail.Delete(_mapper.Map<PurchaseReturn_DetailEntity>(model));
        await PurchaseReturn_Detail.SaveAsync();
    }

    public async Task<IEnumerable<PurchaseReturn_DetailModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<PurchaseReturn_DetailModel>>(await PurchaseReturn_Detail.GetAllAsync());

    public async Task<PurchaseReturn_DetailModel> GetByIDAsync(Guid? id)
        => _mapper.Map<PurchaseReturn_DetailModel>(await PurchaseReturn_Detail.GetByIDAsync(id));

    public async Task UpdateAsync(PurchaseReturn_DetailModel model)
    {
        PurchaseReturn_Detail.Update(_mapper.Map<PurchaseReturn_DetailEntity>(model));
        await PurchaseReturn_Detail.SaveAsync();
    }
}