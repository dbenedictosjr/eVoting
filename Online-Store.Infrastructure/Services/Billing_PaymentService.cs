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
    public class Billing_PaymentService : IBilling_PaymentService
    {
        private readonly IBilling_PaymentRepository Billing_Payment;
    private readonly IMapper _mapper;

    public Billing_PaymentService(IBilling_PaymentRepository reposity, IMapper mapper)
    {
        Billing_Payment = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(Billing_PaymentModel model)
    {
        Billing_Payment.Create(_mapper.Map<Billing_PaymentEntity>(model));
        await Billing_Payment.SaveAsync();
    }

    public async Task DeleteAsync(Billing_PaymentModel model)
    {
        Billing_Payment.Delete(_mapper.Map<Billing_PaymentEntity>(model));
        await Billing_Payment.SaveAsync();
    }

    public async Task<IEnumerable<Billing_PaymentModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<Billing_PaymentModel>>(await Billing_Payment.GetAllAsync());

    public async Task<Billing_PaymentModel> GetByIDAsync(Guid? id)
        => _mapper.Map<Billing_PaymentModel>(await Billing_Payment.GetByIDAsync(id));

    public async Task UpdateAsync(Billing_PaymentModel model)
    {
        Billing_Payment.Update(_mapper.Map<Billing_PaymentEntity>(model));
        await Billing_Payment.SaveAsync();
    }
}