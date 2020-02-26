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
        private readonly IVoteDetailRepository _voteDetailRepository;
        private readonly IMapper _mapper;

        public VoteDetailService(IVoteDetailRepository voteDetailRepository, IMapper mapper)
        {
            _voteDetailRepository = voteDetailRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(VoteDetailModel voteDetail)
        {
            _voteDetailRepository.Create(_mapper.Map<VoteDetailEntity>(voteDetail));
            await _voteDetailRepository.SaveAsync();
        }

        public async Task DeleteAsync(VoteDetailModel voteDetail)
        {
            this._voteDetailRepository.Delete(await _voteDetailRepository.GetByIdAsync(voteDetail.VoteDetailID));
            await _voteDetailRepository.SaveAsync();
        }

        public async Task<IEnumerable<VoteDetailModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<VoteDetailModel>>(await _voteDetailRepository.GetAllAsync());

        public async Task<VoteDetailModel> GetByIdAsync(Guid? id)
            => _mapper.Map<VoteDetailModel>(await _voteDetailRepository.GetByIdAsync(id));

        public async Task UpdateAsync(VoteDetailModel voteDetail)
        {
            _voteDetailRepository.Update(_mapper.Map<VoteDetailEntity>(voteDetail));
            await _voteDetailRepository.SaveAsync();
        }
    }
}
