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
        private readonly IElectionRepository _electionRepository;
        private readonly IMapper _mapper;

        public ElectionService(IElectionRepository electionRepository, IMapper mapper)
        {
            _electionRepository = electionRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(ElectionModel election)
        {
            _electionRepository.Create(_mapper.Map<ElectionEntity>(election));
            await _electionRepository.SaveAsync();
        }

        public async Task DeleteAsync(ElectionModel election)
        {
            this._electionRepository.Delete(await _electionRepository.GetByIdAsync(election.ElectionId));
            await _electionRepository.SaveAsync();
        }

        public async Task<IEnumerable<ElectionModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<ElectionModel>>(await _electionRepository.GetAllAsync());

        public async Task<ElectionModel> GetByIdAsync(Guid? id)
            => _mapper.Map<ElectionModel>(await _electionRepository.GetByIdAsync(id));

        public async Task UpdateAsync(ElectionModel election)
        {
            _electionRepository.Update(_mapper.Map<ElectionEntity>(election));
            await _electionRepository.SaveAsync();
        }
    }
}
