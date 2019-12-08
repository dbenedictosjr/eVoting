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
    public class RTP_DetailService : IRTP_DetailService
    {
        private readonly IRTP_DetailRepository RTP_Detail;
    private readonly IMapper _mapper;

    public RTP_DetailService(IRTP_DetailRepository reposity, IMapper mapper)
    {
        RTP_Detail = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(RTP_DetailModel model)
    {
        RTP_Detail.Create(_mapper.Map<RTP_DetailEntity>(model));
        await RTP_Detail.SaveAsync();
    }

    public async Task DeleteAsync(RTP_DetailModel model)
    {
        RTP_Detail.Delete(_mapper.Map<RTP_DetailEntity>(model));
        await RTP_Detail.SaveAsync();
    }

    public async Task<IEnumerable<RTP_DetailModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<RTP_DetailModel>>(await RTP_Detail.GetAllAsync());

    public async Task<RTP_DetailModel> GetByIDAsync(Guid? id)
        => _mapper.Map<RTP_DetailModel>(await RTP_Detail.GetByIDAsync(id));

    public async Task UpdateAsync(RTP_DetailModel model)
    {
        RTP_Detail.Update(_mapper.Map<RTP_DetailEntity>(model));
        await RTP_Detail.SaveAsync();
    }
}