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
    public class ReferencesService : IReferencesService
    {
        private readonly IReferencesRepository References;
    private readonly IMapper _mapper;

    public ReferencesService(IReferencesRepository reposity, IMapper mapper)
    {
        References = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(ReferencesModel model)
    {
        References.Create(_mapper.Map<ReferencesEntity>(model));
        await References.SaveAsync();
    }

    public async Task DeleteAsync(ReferencesModel model)
    {
        References.Delete(_mapper.Map<ReferencesEntity>(model));
        await References.SaveAsync();
    }

    public async Task<IEnumerable<ReferencesModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<ReferencesModel>>(await References.GetAllAsync());

    public async Task<ReferencesModel> GetByIDAsync(Guid? id)
        => _mapper.Map<ReferencesModel>(await References.GetByIDAsync(id));

    public async Task UpdateAsync(ReferencesModel model)
    {
        References.Update(_mapper.Map<ReferencesEntity>(model));
        await References.SaveAsync();
    }
}