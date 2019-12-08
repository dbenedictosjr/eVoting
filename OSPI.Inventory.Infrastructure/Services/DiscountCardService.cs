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
    public class DiscountCardService : IDiscountCardService
    {
        private readonly IDiscountCardRepository DiscountCard;
    private readonly IMapper _mapper;

    public DiscountCardService(IDiscountCardRepository reposity, IMapper mapper)
    {
        DiscountCard = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(DiscountCardModel model)
    {
        DiscountCard.Create(_mapper.Map<DiscountCardEntity>(model));
        await DiscountCard.SaveAsync();
    }

    public async Task DeleteAsync(DiscountCardModel model)
    {
        DiscountCard.Delete(_mapper.Map<DiscountCardEntity>(model));
        await DiscountCard.SaveAsync();
    }

    public async Task<IEnumerable<DiscountCardModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<DiscountCardModel>>(await DiscountCard.GetAllAsync());

    public async Task<DiscountCardModel> GetByIDAsync(Guid? id)
        => _mapper.Map<DiscountCardModel>(await DiscountCard.GetByIDAsync(id));

    public async Task UpdateAsync(DiscountCardModel model)
    {
        DiscountCard.Update(_mapper.Map<DiscountCardEntity>(model));
        await DiscountCard.SaveAsync();
    }
}