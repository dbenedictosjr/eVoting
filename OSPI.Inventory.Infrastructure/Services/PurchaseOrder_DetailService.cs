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
    public class PurchaseOrder_DetailService : IPurchaseOrder_DetailService
    {
        private readonly IPurchaseOrder_DetailRepository PurchaseOrder_Detail;
    private readonly IMapper _mapper;

    public PurchaseOrder_DetailService(IPurchaseOrder_DetailRepository reposity, IMapper mapper)
    {
        PurchaseOrder_Detail = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(PurchaseOrder_DetailModel model)
    {
        PurchaseOrder_Detail.Create(_mapper.Map<PurchaseOrder_DetailEntity>(model));
        await PurchaseOrder_Detail.SaveAsync();
    }

    public async Task DeleteAsync(PurchaseOrder_DetailModel model)
    {
        PurchaseOrder_Detail.Delete(_mapper.Map<PurchaseOrder_DetailEntity>(model));
        await PurchaseOrder_Detail.SaveAsync();
    }

    public async Task<IEnumerable<PurchaseOrder_DetailModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<PurchaseOrder_DetailModel>>(await PurchaseOrder_Detail.GetAllAsync());

    public async Task<PurchaseOrder_DetailModel> GetByIDAsync(Guid? id)
        => _mapper.Map<PurchaseOrder_DetailModel>(await PurchaseOrder_Detail.GetByIDAsync(id));

    public async Task UpdateAsync(PurchaseOrder_DetailModel model)
    {
        PurchaseOrder_Detail.Update(_mapper.Map<PurchaseOrder_DetailEntity>(model));
        await PurchaseOrder_Detail.SaveAsync();
    }
}