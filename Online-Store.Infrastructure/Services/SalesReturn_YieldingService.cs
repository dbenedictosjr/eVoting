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
    public class SalesReturn_YieldingService : ISalesReturn_YieldingService
    {
        private readonly ISalesReturn_YieldingRepository SalesReturn_Yielding;
    private readonly IMapper _mapper;

    public SalesReturn_YieldingService(ISalesReturn_YieldingRepository reposity, IMapper mapper)
    {
        SalesReturn_Yielding = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(SalesReturn_YieldingModel model)
    {
        SalesReturn_Yielding.Create(_mapper.Map<SalesReturn_YieldingEntity>(model));
        await SalesReturn_Yielding.SaveAsync();
    }

    public async Task DeleteAsync(SalesReturn_YieldingModel model)
    {
        SalesReturn_Yielding.Delete(_mapper.Map<SalesReturn_YieldingEntity>(model));
        await SalesReturn_Yielding.SaveAsync();
    }

    public async Task<IEnumerable<SalesReturn_YieldingModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<SalesReturn_YieldingModel>>(await SalesReturn_Yielding.GetAllAsync());

    public async Task<SalesReturn_YieldingModel> GetByIDAsync(Guid? id)
        => _mapper.Map<SalesReturn_YieldingModel>(await SalesReturn_Yielding.GetByIDAsync(id));

    public async Task UpdateAsync(SalesReturn_YieldingModel model)
    {
        SalesReturn_Yielding.Update(_mapper.Map<SalesReturn_YieldingEntity>(model));
        await SalesReturn_Yielding.SaveAsync();
    }
}