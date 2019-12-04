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
    public class RTPService : IRTPService
    {
        private readonly IRTPRepository RTP;
    private readonly IMapper _mapper;

    public RTPService(IRTPRepository reposity, IMapper mapper)
    {
        RTP = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(RTPModel model)
    {
        RTP.Create(_mapper.Map<RTPEntity>(model));
        await RTP.SaveAsync();
    }

    public async Task DeleteAsync(RTPModel model)
    {
        RTP.Delete(_mapper.Map<RTPEntity>(model));
        await RTP.SaveAsync();
    }

    public async Task<IEnumerable<RTPModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<RTPModel>>(await RTP.GetAllAsync());

    public async Task<RTPModel> GetByIDAsync(Guid? id)
        => _mapper.Map<RTPModel>(await RTP.GetByIDAsync(id));

    public async Task UpdateAsync(RTPModel model)
    {
        RTP.Update(_mapper.Map<RTPEntity>(model));
        await RTP.SaveAsync();
    }
}