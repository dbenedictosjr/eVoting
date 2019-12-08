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
    public class PaymentModeService : IPaymentModeService
    {
        private readonly IPaymentModeRepository PaymentMode;
    private readonly IMapper _mapper;

    public PaymentModeService(IPaymentModeRepository reposity, IMapper mapper)
    {
        PaymentMode = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(PaymentModeModel model)
    {
        PaymentMode.Create(_mapper.Map<PaymentModeEntity>(model));
        await PaymentMode.SaveAsync();
    }

    public async Task DeleteAsync(PaymentModeModel model)
    {
        PaymentMode.Delete(_mapper.Map<PaymentModeEntity>(model));
        await PaymentMode.SaveAsync();
    }

    public async Task<IEnumerable<PaymentModeModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<PaymentModeModel>>(await PaymentMode.GetAllAsync());

    public async Task<PaymentModeModel> GetByIDAsync(Guid? id)
        => _mapper.Map<PaymentModeModel>(await PaymentMode.GetByIDAsync(id));

    public async Task UpdateAsync(PaymentModeModel model)
    {
        PaymentMode.Update(_mapper.Map<PaymentModeEntity>(model));
        await PaymentMode.SaveAsync();
    }
}