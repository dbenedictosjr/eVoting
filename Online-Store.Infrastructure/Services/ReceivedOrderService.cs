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
    public class ReceivedOrderService : IReceivedOrderService
    {
        private readonly IReceivedOrderRepository ReceivedOrder;
    private readonly IMapper _mapper;

    public ReceivedOrderService(IReceivedOrderRepository reposity, IMapper mapper)
    {
        ReceivedOrder = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(ReceivedOrderModel model)
    {
        ReceivedOrder.Create(_mapper.Map<ReceivedOrderEntity>(model));
        await ReceivedOrder.SaveAsync();
    }

    public async Task DeleteAsync(ReceivedOrderModel model)
    {
        ReceivedOrder.Delete(_mapper.Map<ReceivedOrderEntity>(model));
        await ReceivedOrder.SaveAsync();
    }

    public async Task<IEnumerable<ReceivedOrderModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<ReceivedOrderModel>>(await ReceivedOrder.GetAllAsync());

    public async Task<ReceivedOrderModel> GetByIDAsync(Guid? id)
        => _mapper.Map<ReceivedOrderModel>(await ReceivedOrder.GetByIDAsync(id));

    public async Task UpdateAsync(ReceivedOrderModel model)
    {
        ReceivedOrder.Update(_mapper.Map<ReceivedOrderEntity>(model));
        await ReceivedOrder.SaveAsync();
    }
}