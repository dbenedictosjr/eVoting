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
    public class ModuleService : IModuleService
    {
        private readonly IModuleRepository _repository;
        private readonly IMapper _mapper;

        public ModuleService(IModuleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task CreateAsync(ModuleModel model)
        {
            _repository.Create(_mapper.Map<ModuleEntity>(model));
            await _repository.SaveAsync();
        }

        public async Task DeleteAsync(ModuleModel model)
        {
            this._repository.Delete(await _repository.GetByIDAsync(model.ModuleID));
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<ModuleModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<ModuleModel>>(await _repository.GetAllAsync());

        public async Task<ModuleModel> GetByIDAsync(Guid? id)
            => _mapper.Map<ModuleModel>(await _repository.GetByIDAsync(id));

        public async Task UpdateAsync(ModuleModel model)
        {
            _repository.Update(_mapper.Map<ModuleEntity>(model));
            await _repository.SaveAsync();
        }
    }
}
