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
        private readonly IModuleRepository _moduleRepository;
        private readonly IMapper _mapper;

        public ModuleService(IModuleRepository moduleRepository, IMapper mapper)
        {
            _moduleRepository = moduleRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(ModuleModel module)
        {
            _moduleRepository.Create(_mapper.Map<ModuleEntity>(module));
            await _moduleRepository.SaveAsync();
        }

        public async Task DeleteAsync(ModuleModel module)
        {
            this._moduleRepository.Delete(await _moduleRepository.GetByIDAsync(module.ModuleID));
            await _moduleRepository.SaveAsync();
        }

        public async Task<IEnumerable<ModuleModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<ModuleModel>>(await _moduleRepository.GetAllAsync());

        public async Task<ModuleModel> GetByIDAsync(Guid? id)
            => _mapper.Map<ModuleModel>(await _moduleRepository.GetByIDAsync(id));

        public async Task UpdateAsync(ModuleModel module)
        {
            _moduleRepository.Update(_mapper.Map<ModuleEntity>(module));
            await _moduleRepository.SaveAsync();
        }
    }
}
