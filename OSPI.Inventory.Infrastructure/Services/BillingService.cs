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
    public class BillingService : IBillingService
    {
        private readonly IBillingRepository Billing;
    private readonly IMapper _mapper;

    public BillingService(IBillingRepository reposity, IMapper mapper)
    {
        Billing = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(BillingModel model)
    {
        Billing.Create(_mapper.Map<BillingEntity>(model));
        await Billing.SaveAsync();
    }

    public async Task DeleteAsync(BillingModel model)
    {
        Billing.Delete(_mapper.Map<BillingEntity>(model));
        await Billing.SaveAsync();
    }

    public async Task<IEnumerable<BillingModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<BillingModel>>(await Billing.GetAllAsync());

    public async Task<BillingModel> GetByIDAsync(Guid? id)
        => _mapper.Map<BillingModel>(await Billing.GetByIDAsync(id));

    public async Task UpdateAsync(BillingModel model)
    {
        Billing.Update(_mapper.Map<BillingEntity>(model));
        await Billing.SaveAsync();
    }
}