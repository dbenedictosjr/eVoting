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
        private readonly IMemberRepository _memberRepository;
        private readonly IMapper _mapper;

        public MemberService(IMemberRepository memberRepository, IMapper mapper)
        {
            _memberRepository = memberRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(MemberModel model)
        {
            model.MemberId = Guid.NewGuid();
            _memberRepository.Create(_mapper.Map<MemberEntity>(model));
            await _memberRepository.SaveAsync();
        }

        public async Task DeleteAsync(MemberModel model)
        {
            this._memberRepository.Delete(await _memberRepository.GetByIdAsync(model.MemberId));
            await _memberRepository.SaveAsync();
        }

        public async Task<MemberModel> GetByIdAsync(Guid? id)
            => _mapper.Map<MemberModel>(await _memberRepository.GetByIdAsync(id));
        public async Task<MemberModel> GetByCodeAsync(string code)
            => _mapper.Map<MemberModel>(await _memberRepository.GetByCodeAsync(code));
        public async Task<IEnumerable<MemberModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<MemberModel>>(await _memberRepository.GetAllAsync());
        public async Task<IEnumerable<MemberModel>> GetAllVotersAsync()
            => _mapper.Map<IEnumerable<MemberModel>>(await _memberRepository.GetAllVotersAsync());

        public async Task UpdateAsync(MemberModel model)
        {
            _memberRepository.Update(_mapper.Map<MemberEntity>(model));
            await _memberRepository.SaveAsync();
        }
    }
}
