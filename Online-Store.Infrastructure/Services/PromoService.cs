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
    public class PromoService : IPromoService
    {
        private readonly IPromoRepository Promo;
    private readonly IMapper _mapper;

    public PromoService(IPromoRepository reposity, IMapper mapper)
    {
        Promo = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(PromoModel model)
    {
        Promo.Create(_mapper.Map<PromoEntity>(model));
        await Promo.SaveAsync();
    }

    public async Task DeleteAsync(PromoModel model)
    {
        Promo.Delete(_mapper.Map<PromoEntity>(model));
        await Promo.SaveAsync();
    }

    public async Task<IEnumerable<PromoModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<PromoModel>>(await Promo.GetAllAsync());

    public async Task<PromoModel> GetByIDAsync(Guid? id)
        => _mapper.Map<PromoModel>(await Promo.GetByIDAsync(id));

    public async Task UpdateAsync(PromoModel model)
    {
        Promo.Update(_mapper.Map<PromoEntity>(model));
        await Promo.SaveAsync();
    }
}