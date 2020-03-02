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
    public class CandidateService : ICandidateService
    {
        private readonly ICandidateRepository _candidateRepository;
        private readonly IMapper _mapper;

        public CandidateService(ICandidateRepository candidateRepository, IMapper mapper)
        {
            _candidateRepository = candidateRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(CandidateModel candidate)
        {
            _candidateRepository.Create(_mapper.Map<CandidateEntity>(candidate));
            await _candidateRepository.SaveAsync();
        }

        public async Task DeleteAsync(CandidateModel candidate)
        {
            this._candidateRepository.Delete(await _candidateRepository.GetByIdAsync(candidate.CandidateId));
            await _candidateRepository.SaveAsync();
        }

        public async Task<CandidateModel> GetByIdAsync(Guid? id)
            => _mapper.Map<CandidateModel>(await _candidateRepository.GetByIdAsync(id));
        public async Task<IEnumerable<CandidateModel>> GetAllByNomineeIdAsync(Guid? id)
            => _mapper.Map<IEnumerable<CandidateModel>>(await _candidateRepository.GetAllByNomineeIdAsync(id));
        public async Task<IEnumerable<CandidateModel>> GetAllCandidatesAsync(string status)
            => _mapper.Map<IEnumerable<CandidateModel>>(await _candidateRepository.GetAllCandidatesAsync(status));
        public async Task<IEnumerable<CandidateModel>> GetAllByPositionIdAsync(Guid? id, string status)
            => _mapper.Map<IEnumerable<CandidateModel>>(await _candidateRepository.GetAllByPositionIdAsync(id, status));
        public async Task<IEnumerable<CandidateModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<CandidateModel>>(await _candidateRepository.GetAllAsync());

        public async Task UpdateAsync(CandidateModel candidate)
        {
            _candidateRepository.Update(_mapper.Map<CandidateEntity>(candidate));
            await _candidateRepository.SaveAsync();
        }
    }
}
