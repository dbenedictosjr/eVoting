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
        private readonly IPositionRepository _repository;
        private readonly IMapper _mapper;

        public PositionService(IPositionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task CreateAsync(PositionModel model)
        {
            _repository.Create(_mapper.Map<PositionEntity>(model));
            await _repository.SaveAsync();
        }

        public async Task DeleteAsync(PositionModel model)
        {
            this._repository.Delete(await _repository.GetByIDAsync(model.PositionID));
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<PositionModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<PositionModel>>(await _repository.GetAllAsync());

        public async Task<PositionModel> GetByIDAsync(Guid? id)
            => _mapper.Map<PositionModel>(await _repository.GetByIDAsync(id));

        public async Task UpdateAsync(PositionModel model)
        {
            _repository.Update(_mapper.Map<PositionEntity>(model));
            await _repository.SaveAsync();
        }
    }
}
