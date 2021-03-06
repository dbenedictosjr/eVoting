﻿using AutoMapper;
using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;
using OSPI.Infrastructure.Interfaces;
using OSPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSPI.Infrastructure.Services
{
    public class RoleAccessService : IRoleAccessService
    {
        private readonly IRoleAccessRepository _roleAccess;
        private readonly IMapper _mapper;

        public RoleAccessService(IRoleAccessRepository roleAccess, IMapper mapper)
        {
            _roleAccess = roleAccess;
            _mapper = mapper;
        }

        public async Task CreateAsync(RoleAccessModel roleAccess)
        {
            _roleAccess.Create(_mapper.Map<RoleAccessEntity>(roleAccess));
            await _roleAccess.SaveAsync();
        }

        public async Task DeleteAsync(RoleAccessModel roleAccess)
        {
            this._roleAccess.Delete(await _roleAccess.GetByIdAsync(roleAccess.RoleId));
            await _roleAccess.SaveAsync();
        }

        public async Task<IEnumerable<RoleAccessModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<RoleAccessModel>>(await _roleAccess.GetAllAsync());

        public async Task<RoleAccessModel> GetByIdAsync(Guid? id)
            => _mapper.Map<RoleAccessModel>(await _roleAccess.GetByIdAsync(id));

        public async Task<IEnumerable<RoleAccessModel>> GetAllByRoleIdAsync(Guid id)
            => _mapper.Map<IEnumerable<RoleAccessModel>>(await _roleAccess.GetAllByRoleIdAsync(id));

        public async Task UpdateAsync(RoleAccessModel roleAccess)
        {
            _roleAccess.Update(_mapper.Map<RoleAccessEntity>(roleAccess));
            await _roleAccess.SaveAsync();
        }
    }
}