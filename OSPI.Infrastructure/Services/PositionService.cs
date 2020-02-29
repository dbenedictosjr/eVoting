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
    public class PositionService : IPositionService
    {
        private readonly IPositionRepository _positionRepository;
        private readonly IMapper _mapper;

        public PositionService(IPositionRepository positionRepository, IMapper mapper)
        {
            _positionRepository = positionRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(PositionModel model)
        {
            _positionRepository.Create(_mapper.Map<PositionEntity>(model));
            await _positionRepository.SaveAsync();
        }

        public async Task DeleteAsync(PositionModel model)
        {
            this._positionRepository.Delete(await _positionRepository.GetByIdAsync(model.PositionId));
            await _positionRepository.SaveAsync();
        }

        public async Task<IEnumerable<PositionModel>> GetByAllByElectionIdAsync(Guid? id)
            => _mapper.Map<IEnumerable<PositionModel>>(await _positionRepository.GetAllByElectionIdAsync(id));

        public async Task<IEnumerable<PositionModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<PositionModel>>(await _positionRepository.GetAllAsync());

        public async Task<PositionModel> GetByIdAsync(Guid? id)
            => _mapper.Map<PositionModel>(await _positionRepository.GetByIdAsync(id));

        public async Task UpdateAsync(PositionModel model)
        {
            _positionRepository.Update(_mapper.Map<PositionEntity>(model));
            await _positionRepository.SaveAsync();
        }
    }
}