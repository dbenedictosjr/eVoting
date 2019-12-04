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
    public class CurrencyService : ICurrencyService
    {
        private readonly ICurrencyRepository Currency;
    private readonly IMapper _mapper;

    public CurrencyService(ICurrencyRepository reposity, IMapper mapper)
    {
        Currency = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(CurrencyModel model)
    {
        Currency.Create(_mapper.Map<CurrencyEntity>(model));
        await Currency.SaveAsync();
    }

    public async Task DeleteAsync(CurrencyModel model)
    {
        Currency.Delete(_mapper.Map<CurrencyEntity>(model));
        await Currency.SaveAsync();
    }

    public async Task<IEnumerable<CurrencyModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<CurrencyModel>>(await Currency.GetAllAsync());

    public async Task<CurrencyModel> GetByIDAsync(Guid? id)
        => _mapper.Map<CurrencyModel>(await Currency.GetByIDAsync(id));

    public async Task UpdateAsync(CurrencyModel model)
    {
        Currency.Update(_mapper.Map<CurrencyEntity>(model));
        await Currency.SaveAsync();
    }
}