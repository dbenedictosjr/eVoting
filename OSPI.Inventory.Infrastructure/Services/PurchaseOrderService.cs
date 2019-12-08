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
    public class PurchaseOrderService : IPurchaseOrderService
    {
        private readonly IPurchaseOrderRepository PurchaseOrder;
    private readonly IMapper _mapper;

    public PurchaseOrderService(IPurchaseOrderRepository reposity, IMapper mapper)
    {
        PurchaseOrder = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(PurchaseOrderModel model)
    {
        PurchaseOrder.Create(_mapper.Map<PurchaseOrderEntity>(model));
        await PurchaseOrder.SaveAsync();
    }

    public async Task DeleteAsync(PurchaseOrderModel model)
    {
        PurchaseOrder.Delete(_mapper.Map<PurchaseOrderEntity>(model));
        await PurchaseOrder.SaveAsync();
    }

    public async Task<IEnumerable<PurchaseOrderModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<PurchaseOrderModel>>(await PurchaseOrder.GetAllAsync());

    public async Task<PurchaseOrderModel> GetByIDAsync(Guid? id)
        => _mapper.Map<PurchaseOrderModel>(await PurchaseOrder.GetByIDAsync(id));

    public async Task UpdateAsync(PurchaseOrderModel model)
    {
        PurchaseOrder.Update(_mapper.Map<PurchaseOrderEntity>(model));
        await PurchaseOrder.SaveAsync();
    }
}