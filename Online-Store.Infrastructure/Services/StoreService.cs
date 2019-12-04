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
    public class StoreService : IStoreService
    {
        private readonly IStoreRepository Store;
    private readonly IMapper _mapper;

    public StoreService(IStoreRepository reposity, IMapper mapper)
    {
        Store = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(StoreModel model)
    {
        Store.Create(_mapper.Map<StoreEntity>(model));
        await Store.SaveAsync();
    }

    public async Task DeleteAsync(StoreModel model)
    {
        Store.Delete(_mapper.Map<StoreEntity>(model));
        await Store.SaveAsync();
    }

    public async Task<IEnumerable<StoreModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<StoreModel>>(await Store.GetAllAsync());

    public async Task<StoreModel> GetByIDAsync(Guid? id)
        => _mapper.Map<StoreModel>(await Store.GetByIDAsync(id));

    public async Task UpdateAsync(StoreModel model)
    {
        Store.Update(_mapper.Map<StoreEntity>(model));
        await Store.SaveAsync();
    }
}