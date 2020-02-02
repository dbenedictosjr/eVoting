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
        private readonly ICandidateRepository _repository;
        private readonly IMapper _mapper;

        public CandidateService(ICandidateRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task CreateAsync(CandidateModel model)
        {
            _repository.Create(_mapper.Map<CandidateEntity>(model));
            await _repository.SaveAsync();
        }

        public async Task DeleteAsync(CandidateModel model)
        {
            this._repository.Delete(_repository.GetByID(model.CandidateID));
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<CandidateModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<CandidateModel>>(await _repository.GetAllAsync());

        public async Task<CandidateModel> GetByIDAsync(Guid? id)
            => _mapper.Map<CandidateModel>(await _repository.GetByIDAsync(id));

        public async Task UpdateAsync(CandidateModel model)
        {
            _repository.Update(_mapper.Map<CandidateEntity>(model));
            await _repository.SaveAsync();
        }
    }
}
