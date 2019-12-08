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
    public class ReceivedOrder_DetailService : IReceivedOrder_DetailService
    {
        private readonly IReceivedOrder_DetailRepository ReceivedOrder_Detail;
    private readonly IMapper _mapper;

    public ReceivedOrder_DetailService(IReceivedOrder_DetailRepository reposity, IMapper mapper)
    {
        ReceivedOrder_Detail = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(ReceivedOrder_DetailModel model)
    {
        ReceivedOrder_Detail.Create(_mapper.Map<ReceivedOrder_DetailEntity>(model));
        await ReceivedOrder_Detail.SaveAsync();
    }

    public async Task DeleteAsync(ReceivedOrder_DetailModel model)
    {
        ReceivedOrder_Detail.Delete(_mapper.Map<ReceivedOrder_DetailEntity>(model));
        await ReceivedOrder_Detail.SaveAsync();
    }

    public async Task<IEnumerable<ReceivedOrder_DetailModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<ReceivedOrder_DetailModel>>(await ReceivedOrder_Detail.GetAllAsync());

    public async Task<ReceivedOrder_DetailModel> GetByIDAsync(Guid? id)
        => _mapper.Map<ReceivedOrder_DetailModel>(await ReceivedOrder_Detail.GetByIDAsync(id));

    public async Task UpdateAsync(ReceivedOrder_DetailModel model)
    {
        ReceivedOrder_Detail.Update(_mapper.Map<ReceivedOrder_DetailEntity>(model));
        await ReceivedOrder_Detail.SaveAsync();
    }
}