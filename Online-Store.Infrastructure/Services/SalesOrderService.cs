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
    public class SalesOrderService : ISalesOrderService
    {
        private readonly ISalesOrderRepository SalesOrder;
    private readonly IMapper _mapper;

    public SalesOrderService(ISalesOrderRepository reposity, IMapper mapper)
    {
        SalesOrder = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(SalesOrderModel model)
    {
        SalesOrder.Create(_mapper.Map<SalesOrderEntity>(model));
        await SalesOrder.SaveAsync();
    }

    public async Task DeleteAsync(SalesOrderModel model)
    {
        SalesOrder.Delete(_mapper.Map<SalesOrderEntity>(model));
        await SalesOrder.SaveAsync();
    }

    public async Task<IEnumerable<SalesOrderModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<SalesOrderModel>>(await SalesOrder.GetAllAsync());

    public async Task<SalesOrderModel> GetByIDAsync(Guid? id)
        => _mapper.Map<SalesOrderModel>(await SalesOrder.GetByIDAsync(id));

    public async Task UpdateAsync(SalesOrderModel model)
    {
        SalesOrder.Update(_mapper.Map<SalesOrderEntity>(model));
        await SalesOrder.SaveAsync();
    }
}