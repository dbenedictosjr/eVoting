using AutoMapper;
using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;
using OSPI.Infrastructure.Interfaces;
using OSPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Infrastructure.Services
{
    public class ElectionService : IElectionService
    {
        private readonly IElectionRepository _repository;
        private readonly IMapper _mapper;

        public ElectionService(IElectionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task CreateAsync(ElectionModel model)
        {
            _repository.Create(_mapper.Map<ElectionEntity>(model));
            await _repository.SaveAsync();
        }

        public async Task DeleteAsync(ElectionModel model)
        {
            this._repository.Delete(await _repository.GetByIDAsync(model.ElectionID));
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<ElectionModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<ElectionModel>>(await _repository.GetAllAsync());

        public async Task<ElectionModel> GetByIDAsync(Guid? id)
            => _mapper.Map<ElectionModel>(await _repository.GetByIDAsync(id));

        public async Task UpdateAsync(ElectionModel model)
        {
            _repository.Update(_mapper.Map<ElectionEntity>(model));
            await _repository.SaveAsync();
        }
    }
}
