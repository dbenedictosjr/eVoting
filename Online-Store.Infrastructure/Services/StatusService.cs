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
    public class StatusService : IStatusService
    {
        private readonly IStatusRepository Status;
    private readonly IMapper _mapper;

    public StatusService(IStatusRepository reposity, IMapper mapper)
    {
        Status = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(StatusModel model)
    {
        Status.Create(_mapper.Map<StatusEntity>(model));
        await Status.SaveAsync();
    }

    public async Task DeleteAsync(StatusModel model)
    {
        Status.Delete(_mapper.Map<StatusEntity>(model));
        await Status.SaveAsync();
    }

    public async Task<IEnumerable<StatusModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<StatusModel>>(await Status.GetAllAsync());

    public async Task<StatusModel> GetByIDAsync(Guid? id)
        => _mapper.Map<StatusModel>(await Status.GetByIDAsync(id));

    public async Task UpdateAsync(StatusModel model)
    {
        Status.Update(_mapper.Map<StatusEntity>(model));
        await Status.SaveAsync();
    }
}