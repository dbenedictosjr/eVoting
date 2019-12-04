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
    public class UOMService : IUOMService
    {
        private readonly IUOMRepository UOM;
    private readonly IMapper _mapper;

    public UOMService(IUOMRepository reposity, IMapper mapper)
    {
        UOM = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(UOMModel model)
    {
        UOM.Create(_mapper.Map<UOMEntity>(model));
        await UOM.SaveAsync();
    }

    public async Task DeleteAsync(UOMModel model)
    {
        UOM.Delete(_mapper.Map<UOMEntity>(model));
        await UOM.SaveAsync();
    }

    public async Task<IEnumerable<UOMModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<UOMModel>>(await UOM.GetAllAsync());

    public async Task<UOMModel> GetByIDAsync(Guid? id)
        => _mapper.Map<UOMModel>(await UOM.GetByIDAsync(id));

    public async Task UpdateAsync(UOMModel model)
    {
        UOM.Update(_mapper.Map<UOMEntity>(model));
        await UOM.SaveAsync();
    }
}