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
    public class BallotService : IBallotService
    {
        private readonly IBallotRepository _repository;
        private readonly IMapper _mapper;

        public BallotService(IBallotRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task CreateAsync(BallotModel model)
        {
            _repository.Create(_mapper.Map<BallotEntity>(model));
            await _repository.SaveAsync();
        }

        public async Task DeleteAsync(BallotModel model)
        {
            this._repository.Delete(_repository.GetByID(model.BallotID));
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<BallotModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<BallotModel>>(await _repository.GetAllAsync());

        public async Task<BallotModel> GetByIDAsync(Guid? id)
            => _mapper.Map<BallotModel>(await _repository.GetByIDAsync(id));

        public async Task UpdateAsync(BallotModel model)
        {
            _repository.Update(_mapper.Map<BallotEntity>(model));
            await _repository.SaveAsync();
        }
    }
}
