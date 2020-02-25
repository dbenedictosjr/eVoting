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
        private readonly IVoteRepository _voteRepository;
        private readonly IMapper _mapper;

        public VoteService(IVoteRepository voteRepository, IMapper mapper)
        {
            _voteRepository = voteRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(VoteModel vote)
        {
            _voteRepository.Create(_mapper.Map<VoteEntity>(vote));
            await _voteRepository.SaveAsync();
        }

        public async Task DeleteAsync(VoteModel vote)
        {
            this._voteRepository.Delete(await _voteRepository.GetByIDAsync(vote.VoteID));
            await _voteRepository.SaveAsync();
        }

        public async Task<IEnumerable<VoteModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<VoteModel>>(await _voteRepository.GetAllAsync());

        public async Task<VoteModel> GetByIDAsync(Guid? id)
            => _mapper.Map<VoteModel>(await _voteRepository.GetByIDAsync(id));

        public async Task UpdateAsync(VoteModel vote)
        {
            _voteRepository.Update(_mapper.Map<VoteEntity>(vote));
            await _voteRepository.SaveAsync();
        }
    }
}
