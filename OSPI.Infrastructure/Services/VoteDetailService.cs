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
    public class VoteDetailService : IVoteDetailService
    {
        private readonly IVoteDetailRepository _repository;
        private readonly IMapper _mapper;

        public VoteDetailService(IVoteDetailRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task CreateAsync(VoteDetailModel model)
        {
            _repository.Create(_mapper.Map<VoteDetailEntity>(model));
            await _repository.SaveAsync();
        }

        public async Task DeleteAsync(VoteDetailModel model)
        {
            this._repository.Delete(await _repository.GetByIDAsync(model.VoteDetailID));
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<VoteDetailModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<VoteDetailModel>>(await _repository.GetAllAsync());

        public async Task<VoteDetailModel> GetByIDAsync(Guid? id)
            => _mapper.Map<VoteDetailModel>(await _repository.GetByIDAsync(id));

        public async Task UpdateAsync(VoteDetailModel model)
        {
            _repository.Update(_mapper.Map<VoteDetailEntity>(model));
            await _repository.SaveAsync();
        }
    }
}
