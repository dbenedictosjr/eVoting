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
    public class GiftCheckService : IGiftCheckService
    {
        private readonly IGiftCheckRepository GiftCheck;
    private readonly IMapper _mapper;

    public GiftCheckService(IGiftCheckRepository reposity, IMapper mapper)
    {
        GiftCheck = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(GiftCheckModel model)
    {
        GiftCheck.Create(_mapper.Map<GiftCheckEntity>(model));
        await GiftCheck.SaveAsync();
    }

    public async Task DeleteAsync(GiftCheckModel model)
    {
        GiftCheck.Delete(_mapper.Map<GiftCheckEntity>(model));
        await GiftCheck.SaveAsync();
    }

    public async Task<IEnumerable<GiftCheckModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<GiftCheckModel>>(await GiftCheck.GetAllAsync());

    public async Task<GiftCheckModel> GetByIDAsync(Guid? id)
        => _mapper.Map<GiftCheckModel>(await GiftCheck.GetByIDAsync(id));

    public async Task UpdateAsync(GiftCheckModel model)
    {
        GiftCheck.Update(_mapper.Map<GiftCheckEntity>(model));
        await GiftCheck.SaveAsync();
    }
}