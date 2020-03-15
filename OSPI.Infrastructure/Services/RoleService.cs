using AutoMapper;
using OSPI.Domain;
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
        private readonly ApplicationDbContext _context;
        private readonly IRoleRepository _roleRepository;
        private readonly IRoleAccessRepository _roleAccessRepository;
        private readonly IMapper _mapper;

        public RoleService(ApplicationDbContext context, IRoleRepository roleRepository, IRoleAccessRepository roleAccessRepository, IMapper mapper)
        {
            _context = context;
            _roleRepository = roleRepository;
            _roleAccessRepository = roleAccessRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(RoleModel role)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.Roles.Add(_mapper.Map<RoleEntity>(role));
                    _context.Save();

                    foreach (var item in role.RoleAccesses)
                    {
                        _context.RoleAccesses.Add(_mapper.Map<RoleAccessEntity>(item));
                        _context.Save();
                    }
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
        }

        public async Task DeleteAsync(RoleModel role)
        {
            this._roleRepository.Delete(await _roleRepository.GetByIdAsync(role.RoleId));
            await _roleRepository.SaveAsync();
        }

        public async Task<IEnumerable<RoleModel>> GetAllAsync() => _mapper.Map<IEnumerable<RoleModel>>(await _roleRepository.GetAllAsync());

        public async Task<RoleModel> GetByIdAsync(Guid? id)
        {
            return _mapper.Map<RoleModel>(await _roleRepository.GetByIdAsync(id));
        }

        public async Task UpdateAsync(RoleModel role)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.Roles.Update(_mapper.Map<RoleEntity>(role));
                    _context.Save();

                    foreach (var item in role.RoleAccesses)
                    {
                        _context.RoleAccesses.Update(_mapper.Map<RoleAccessEntity>(item));
                        _context.Save();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }
            }
        }
    }
}