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
    public class Billing_DetailService : IBilling_DetailService
    {
        private readonly IBilling_DetailRepository Billing_Detail;
    private readonly IMapper _mapper;

    public Billing_DetailService(IBilling_DetailRepository reposity, IMapper mapper)
    {
        Billing_Detail = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(Billing_DetailModel model)
    {
        Billing_Detail.Create(_mapper.Map<Billing_DetailEntity>(model));
        await Billing_Detail.SaveAsync();
    }

    public async Task DeleteAsync(Billing_DetailModel model)
    {
        Billing_Detail.Delete(_mapper.Map<Billing_DetailEntity>(model));
        await Billing_Detail.SaveAsync();
    }

    public async Task<IEnumerable<Billing_DetailModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<Billing_DetailModel>>(await Billing_Detail.GetAllAsync());

    public async Task<Billing_DetailModel> GetByIDAsync(Guid? id)
        => _mapper.Map<Billing_DetailModel>(await Billing_Detail.GetByIDAsync(id));

    public async Task UpdateAsync(Billing_DetailModel model)
    {
        Billing_Detail.Update(_mapper.Map<Billing_DetailEntity>(model));
        await Billing_Detail.SaveAsync();
    }
}