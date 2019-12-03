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
    public class PurchaseReturnService : IPurchaseReturnService
    {
        private readonly IPurchaseReturnRepository PurchaseReturn;
    private readonly IMapper _mapper;

    public PurchaseReturnService(IPurchaseReturnRepository reposity, IMapper mapper)
    {
        PurchaseReturn = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(PurchaseReturnModel model)
    {
        PurchaseReturn.Create(_mapper.Map<PurchaseReturnEntity>(model));
        await PurchaseReturn.SaveAsync();
    }

    public async Task DeleteAsync(PurchaseReturnModel model)
    {
        PurchaseReturn.Delete(_mapper.Map<PurchaseReturnEntity>(model));
        await PurchaseReturn.SaveAsync();
    }

    public async Task<IEnumerable<PurchaseReturnModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<PurchaseReturnModel>>(await PurchaseReturn.GetAllAsync());

    public async Task<PurchaseReturnModel> GetByIDAsync(Guid? id)
        => _mapper.Map<PurchaseReturnModel>(await PurchaseReturn.GetByIDAsync(id));

    public async Task UpdateAsync(PurchaseReturnModel model)
    {
        PurchaseReturn.Update(_mapper.Map<PurchaseReturnEntity>(model));
        await PurchaseReturn.SaveAsync();
    }
}