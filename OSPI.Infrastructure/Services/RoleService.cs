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
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;

        public RoleService(IRoleRepository roleRepository, IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(RoleModel role)
        {
            _roleRepository.Create(_mapper.Map<RoleEntity>(role));
            await _roleRepository.SaveAsync();
        }

        public async Task DeleteAsync(RoleModel role)
        {
            this._roleRepository.Delete(await _roleRepository.GetByIdAsync(role.RoleID));
            await _roleRepository.SaveAsync();
        }

        public async Task<IEnumerable<RoleModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<RoleModel>>(await _roleRepository.GetAllAsync());

        public async Task<RoleModel> GetByIdAsync(Guid? id)
            => _mapper.Map<RoleModel>(await _roleRepository.GetByIdAsync(id));

        public async Task UpdateAsync(RoleModel role)
        {
            _roleRepository.Update(_mapper.Map<RoleEntity>(role));
            await _roleRepository.SaveAsync();
        }
    }
}