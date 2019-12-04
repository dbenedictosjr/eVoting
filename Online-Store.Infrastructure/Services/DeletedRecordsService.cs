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
    public class DeletedRecordsService : IDeletedRecordsService
    {
        private readonly IDeletedRecordsRepository DeletedRecords;
    private readonly IMapper _mapper;

    public DeletedRecordsService(IDeletedRecordsRepository reposity, IMapper mapper)
    {
        DeletedRecords = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(DeletedRecordsModel model)
    {
        DeletedRecords.Create(_mapper.Map<DeletedRecordsEntity>(model));
        await DeletedRecords.SaveAsync();
    }

    public async Task DeleteAsync(DeletedRecordsModel model)
    {
        DeletedRecords.Delete(_mapper.Map<DeletedRecordsEntity>(model));
        await DeletedRecords.SaveAsync();
    }

    public async Task<IEnumerable<DeletedRecordsModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<DeletedRecordsModel>>(await DeletedRecords.GetAllAsync());

    public async Task<DeletedRecordsModel> GetByIDAsync(Guid? id)
        => _mapper.Map<DeletedRecordsModel>(await DeletedRecords.GetByIDAsync(id));

    public async Task UpdateAsync(DeletedRecordsModel model)
    {
        DeletedRecords.Update(_mapper.Map<DeletedRecordsEntity>(model));
        await DeletedRecords.SaveAsync();
    }
}