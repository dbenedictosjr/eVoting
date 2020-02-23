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
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _repository;
        private readonly IMapper _mapper;

        public RoleService(IRoleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task CreateAsync(RoleModel model)
        {
            _repository.Create(_mapper.Map<RoleEntity>(model));
            await _repository.SaveAsync();
        }

        public async Task DeleteAsync(RoleModel model)
        {
            this._repository.Delete(await _repository.GetByIDAsync(model.RoleID));
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<RoleModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<RoleModel>>(await _repository.GetAllAsync());

        public async Task<RoleModel> GetByIDAsync(Guid? id)
            => _mapper.Map<RoleModel>(await _repository.GetByIDAsync(id));

        public async Task UpdateAsync(RoleModel model)
        {
            _repository.Update(_mapper.Map<RoleEntity>(model));
            await _repository.SaveAsync();
        }
    }
}