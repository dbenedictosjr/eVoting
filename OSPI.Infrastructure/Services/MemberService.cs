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
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _repository;
        private readonly IMapper _mapper;

        public MemberService(IMemberRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task CreateAsync(MemberModel model)
        {
            model.MemberID = Guid.NewGuid();
            _repository.Create(_mapper.Map<MemberEntity>(model));
            await _repository.SaveAsync();
        }

        public async Task DeleteAsync(MemberModel model)
        {
            this._repository.Delete(await _repository.GetByIDAsync(model.MemberID));
            await _repository.SaveAsync();
        }

        public async Task<MemberModel> GetByIDAsync(Guid? id)
            => _mapper.Map<MemberModel>(await _repository.GetByIDAsync(id));
        public async Task<MemberModel> GetByCodeAsync(string code)
            => _mapper.Map<MemberModel>(await _repository.GetByCodeAsync(code));
        public async Task<IEnumerable<MemberModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<MemberModel>>(await _repository.GetAllAsync());

        public async Task UpdateAsync(MemberModel model)
        {
            _repository.Update(_mapper.Map<MemberEntity>(model));
            await _repository.SaveAsync();
        }
    }
}
