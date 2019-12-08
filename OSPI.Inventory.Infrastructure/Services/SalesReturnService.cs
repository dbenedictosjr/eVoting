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
    public class SalesReturnService : ISalesReturnService
    {
        private readonly ISalesReturnRepository SalesReturn;
    private readonly IMapper _mapper;

    public SalesReturnService(ISalesReturnRepository reposity, IMapper mapper)
    {
        SalesReturn = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(SalesReturnModel model)
    {
        SalesReturn.Create(_mapper.Map<SalesReturnEntity>(model));
        await SalesReturn.SaveAsync();
    }

    public async Task DeleteAsync(SalesReturnModel model)
    {
        SalesReturn.Delete(_mapper.Map<SalesReturnEntity>(model));
        await SalesReturn.SaveAsync();
    }

    public async Task<IEnumerable<SalesReturnModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<SalesReturnModel>>(await SalesReturn.GetAllAsync());

    public async Task<SalesReturnModel> GetByIDAsync(Guid? id)
        => _mapper.Map<SalesReturnModel>(await SalesReturn.GetByIDAsync(id));

    public async Task UpdateAsync(SalesReturnModel model)
    {
        SalesReturn.Update(_mapper.Map<SalesReturnEntity>(model));
        await SalesReturn.SaveAsync();
    }
}