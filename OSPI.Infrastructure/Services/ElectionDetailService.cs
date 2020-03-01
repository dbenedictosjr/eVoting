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
    public class ElectionDetailService : IElectionDetailService
    {
        private readonly IElectionDetailRepository _electionDetailRepository;
        private readonly IMapper _mapper;

        public ElectionDetailService(IElectionDetailRepository electionDetailRepository, IMapper mapper)
        {
            _electionDetailRepository = electionDetailRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(ElectionDetailModel electionDetail)
        {
            _electionDetailRepository.Create(_mapper.Map<ElectionDetailEntity>(electionDetail));
            await _electionDetailRepository.SaveAsync();
        }

        public async Task DeleteAsync(ElectionDetailModel electionDetail)
        {
            this._electionDetailRepository.Delete(await _electionDetailRepository.GetByIdAsync(electionDetail.ElectionDetailId));
            await _electionDetailRepository.SaveAsync();
        }

        public async Task<IEnumerable<ElectionDetailModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<ElectionDetailModel>>(await _electionDetailRepository.GetAllAsync());

        public async Task<ElectionDetailModel> GetByIdAsync(Guid? id)
            => _mapper.Map<ElectionDetailModel>(await _electionDetailRepository.GetByIdAsync(id));

        public async Task UpdateAsync(ElectionDetailModel electionDetail)
        {
            _electionDetailRepository.Update(_mapper.Map<ElectionDetailEntity>(electionDetail));
            await _electionDetailRepository.SaveAsync();
        }
    }
}
