﻿using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;
using Online_Store.Infrastructure.Interfaces;
using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;

namespace Online_Store.Infrastructure.Services
{ }
    public class DiscountService : IDiscountService
    {
        private readonly IDiscountRepository Discount;
    private readonly IMapper _mapper;

    public DiscountService(IDiscountRepository reposity, IMapper mapper)
    {
        Discount = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(DiscountModel model)
    {
        Discount.Create(_mapper.Map<DiscountEntity>(model));
        await Discount.SaveAsync();
    }

    public async Task DeleteAsync(DiscountModel model)
    {
        Discount.Delete(_mapper.Map<DiscountEntity>(model));
        await Discount.SaveAsync();
    }

    public async Task<IEnumerable<DiscountModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<DiscountModel>>(await Discount.GetAllAsync());

    public async Task<DiscountModel> GetByIDAsync(Guid? id)
        => _mapper.Map<DiscountModel>(await Discount.GetByIDAsync(id));

    public async Task UpdateAsync(DiscountModel model)
    {
        Discount.Update(_mapper.Map<DiscountEntity>(model));
        await Discount.SaveAsync();
    }
}