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
    public class SalesOrder_DetailService : ISalesOrder_DetailService
    {
        private readonly ISalesOrder_DetailRepository SalesOrder_Detail;
    private readonly IMapper _mapper;

    public SalesOrder_DetailService(ISalesOrder_DetailRepository reposity, IMapper mapper)
    {
        SalesOrder_Detail = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(SalesOrder_DetailModel model)
    {
        SalesOrder_Detail.Create(_mapper.Map<SalesOrder_DetailEntity>(model));
        await SalesOrder_Detail.SaveAsync();
    }

    public async Task DeleteAsync(SalesOrder_DetailModel model)
    {
        SalesOrder_Detail.Delete(_mapper.Map<SalesOrder_DetailEntity>(model));
        await SalesOrder_Detail.SaveAsync();
    }

    public async Task<IEnumerable<SalesOrder_DetailModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<SalesOrder_DetailModel>>(await SalesOrder_Detail.GetAllAsync());

    public async Task<SalesOrder_DetailModel> GetByIDAsync(Guid? id)
        => _mapper.Map<SalesOrder_DetailModel>(await SalesOrder_Detail.GetByIDAsync(id));

    public async Task UpdateAsync(SalesOrder_DetailModel model)
    {
        SalesOrder_Detail.Update(_mapper.Map<SalesOrder_DetailEntity>(model));
        await SalesOrder_Detail.SaveAsync();
    }
}