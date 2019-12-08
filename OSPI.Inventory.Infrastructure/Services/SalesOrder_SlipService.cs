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
    public class SalesOrder_SlipService : ISalesOrder_SlipService
    {
        private readonly ISalesOrder_SlipRepository SalesOrder_Slip;
    private readonly IMapper _mapper;

    public SalesOrder_SlipService(ISalesOrder_SlipRepository reposity, IMapper mapper)
    {
        SalesOrder_Slip = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(SalesOrder_SlipModel model)
    {
        SalesOrder_Slip.Create(_mapper.Map<SalesOrder_SlipEntity>(model));
        await SalesOrder_Slip.SaveAsync();
    }

    public async Task DeleteAsync(SalesOrder_SlipModel model)
    {
        SalesOrder_Slip.Delete(_mapper.Map<SalesOrder_SlipEntity>(model));
        await SalesOrder_Slip.SaveAsync();
    }

    public async Task<IEnumerable<SalesOrder_SlipModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<SalesOrder_SlipModel>>(await SalesOrder_Slip.GetAllAsync());

    public async Task<SalesOrder_SlipModel> GetByIDAsync(Guid? id)
        => _mapper.Map<SalesOrder_SlipModel>(await SalesOrder_Slip.GetByIDAsync(id));

    public async Task UpdateAsync(SalesOrder_SlipModel model)
    {
        SalesOrder_Slip.Update(_mapper.Map<SalesOrder_SlipEntity>(model));
        await SalesOrder_Slip.SaveAsync();
    }
}