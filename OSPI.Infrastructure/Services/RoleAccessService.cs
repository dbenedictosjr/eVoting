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
    public class RoleAccessService : IRoleAccessService
    {
        private readonly IRoleAccessRepository _repository;
        private readonly IMapper _mapper;

        public RoleAccessService(IRoleAccessRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task CreateAsync(RoleAccessModel model)
        {
            _repository.Create(_mapper.Map<RoleAccessEntity>(model));
            await _repository.SaveAsync();
        }

        public async Task DeleteAsync(RoleAccessModel model)
        {
            this._repository.Delete(_repository.GetByID(model.RoleID));
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<RoleAccessModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<RoleAccessModel>>(await _repository.GetAllAsync());

        public async Task<RoleAccessModel> GetByIDAsync(Guid? id)
            => _mapper.Map<RoleAccessModel>(await _repository.GetByIDAsync(id));

        public async Task UpdateAsync(RoleAccessModel model)
        {
            _repository.Update(_mapper.Map<RoleAccessEntity>(model));
            await _repository.SaveAsync();
        }
    }
}