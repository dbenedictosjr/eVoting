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
    public class ResultService : IResultService
    {
        private readonly IResultRepository _repository;
        private readonly IMapper _mapper;

        public ResultService(IResultRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task CreateAsync(ResultModel model)
        {
            _repository.Create(_mapper.Map<ResultEntity>(model));
            await _repository.SaveAsync();
        }

        public async Task DeleteAsync(ResultModel model)
        {
            this._repository.Delete(_repository.GetByID(model.ResultID));
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<ResultModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<ResultModel>>(await _repository.GetAllAsync());

        public async Task<ResultModel> GetByIDAsync(Guid? id)
            => _mapper.Map<ResultModel>(await _repository.GetByIDAsync(id));

        public async Task UpdateAsync(ResultModel model)
        {
            _repository.Update(_mapper.Map<ResultEntity>(model));
            await _repository.SaveAsync();
        }
    }
}
