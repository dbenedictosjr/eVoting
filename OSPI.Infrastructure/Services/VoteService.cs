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
    public class VoteService : IVoteService
    {
        private readonly IVoteRepository _repository;
        private readonly IMapper _mapper;

        public VoteService(IVoteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task CreateAsync(VoteModel model)
        {
            _repository.Create(_mapper.Map<VoteEntity>(model));
            await _repository.SaveAsync();
        }

        public async Task DeleteAsync(VoteModel model)
        {
            this._repository.Delete(_repository.GetByID(model.VoteID));
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<VoteModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<VoteModel>>(await _repository.GetAllAsync());

        public async Task<VoteModel> GetByIDAsync(Guid? id)
            => _mapper.Map<VoteModel>(await _repository.GetByIDAsync(id));

        public async Task UpdateAsync(VoteModel model)
        {
            _repository.Update(_mapper.Map<VoteEntity>(model));
            await _repository.SaveAsync();
        }
    }
}
