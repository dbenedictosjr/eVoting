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
    public class SalesReturn_DetailService : ISalesReturn_DetailService
    {
        private readonly ISalesReturn_DetailRepository SalesReturn_Detail;
    private readonly IMapper _mapper;

    public SalesReturn_DetailService(ISalesReturn_DetailRepository reposity, IMapper mapper)
    {
        SalesReturn_Detail = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(SalesReturn_DetailModel model)
    {
        SalesReturn_Detail.Create(_mapper.Map<SalesReturn_DetailEntity>(model));
        await SalesReturn_Detail.SaveAsync();
    }

    public async Task DeleteAsync(SalesReturn_DetailModel model)
    {
        SalesReturn_Detail.Delete(_mapper.Map<SalesReturn_DetailEntity>(model));
        await SalesReturn_Detail.SaveAsync();
    }

    public async Task<IEnumerable<SalesReturn_DetailModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<SalesReturn_DetailModel>>(await SalesReturn_Detail.GetAllAsync());

    public async Task<SalesReturn_DetailModel> GetByIDAsync(Guid? id)
        => _mapper.Map<SalesReturn_DetailModel>(await SalesReturn_Detail.GetByIDAsync(id));

    public async Task UpdateAsync(SalesReturn_DetailModel model)
    {
        SalesReturn_Detail.Update(_mapper.Map<SalesReturn_DetailEntity>(model));
        await SalesReturn_Detail.SaveAsync();
    }
}