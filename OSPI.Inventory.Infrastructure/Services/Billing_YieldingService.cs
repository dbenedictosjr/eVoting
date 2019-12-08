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
    public class Billing_YieldingService : IBilling_YieldingService
    {
        private readonly IBilling_YieldingRepository Billing_Yielding;
    private readonly IMapper _mapper;

    public Billing_YieldingService(IBilling_YieldingRepository reposity, IMapper mapper)
    {
        Billing_Yielding = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(Billing_YieldingModel model)
    {
        Billing_Yielding.Create(_mapper.Map<Billing_YieldingEntity>(model));
        await Billing_Yielding.SaveAsync();
    }

    public async Task DeleteAsync(Billing_YieldingModel model)
    {
        Billing_Yielding.Delete(_mapper.Map<Billing_YieldingEntity>(model));
        await Billing_Yielding.SaveAsync();
    }

    public async Task<IEnumerable<Billing_YieldingModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<Billing_YieldingModel>>(await Billing_Yielding.GetAllAsync());

    public async Task<Billing_YieldingModel> GetByIDAsync(Guid? id)
        => _mapper.Map<Billing_YieldingModel>(await Billing_Yielding.GetByIDAsync(id));

    public async Task UpdateAsync(Billing_YieldingModel model)
    {
        Billing_Yielding.Update(_mapper.Map<Billing_YieldingEntity>(model));
        await Billing_Yielding.SaveAsync();
    }
}