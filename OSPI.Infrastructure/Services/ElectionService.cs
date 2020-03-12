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
    public class ElectionService : IElectionService
    {
        private readonly ApplicationDbContext _context;
        private readonly IElectionRepository _electionRepository;
        private readonly IElectionDetailRepository _electionDetailRepository;
        private readonly IMemberRepository _memberRepository;
        private readonly IMapper _mapper;

        public ElectionService(ApplicationDbContext context, IElectionRepository electionRepository, IElectionDetailRepository electionDetailRepository, IMemberRepository memberRepository, IMapper mapper)
        {
            _context = context;
            _electionRepository = electionRepository;
            _electionDetailRepository = electionDetailRepository;
            _memberRepository = memberRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(ElectionModel election)
        {
            _electionRepository.Create(_mapper.Map<ElectionEntity>(election));
            await _electionRepository.SaveAsync();
        }

        public async Task DeleteAsync(ElectionModel election)
        {
            this._electionRepository.Delete(await _electionRepository.GetByIdAsync(election.ElectionId));
            await _electionRepository.SaveAsync();
        }

        public async Task<IEnumerable<ElectionModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<ElectionModel>>(await _electionRepository.GetAllAsync());

        public async Task<ElectionModel> GetByIdAsync(Guid? id)
            => _mapper.Map<ElectionModel>(await _electionRepository.GetByIdAsync(id));

        public async Task UpdateAsync(ElectionModel election)
        {
            _electionRepository.Update(_mapper.Map<ElectionEntity>(election));
            await _electionRepository.SaveAsync();
        }

        public async Task SaveElection(ElectionModel election, List<CPositionModel> data)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    MemberEntity member = _memberRepository.GetById(election.MemberId);
                    member.Voted = true;
                    _memberRepository.Update(member);
                    _memberRepository.SaveAsync();

                    _electionRepository.Create(_mapper.Map<ElectionEntity>(election));
                    _electionRepository.SaveAsync();

                    foreach (CPositionModel item in data)
                    {
                        foreach (CCandidateModel cModel in item.Candidates)
                        {
                            _electionDetailRepository.Create(new ElectionDetailEntity
                            {
                                ElectionDetailId = Guid.NewGuid(),
                                ElectionId = election.ElectionId,
                                CandidateId = cModel.CandidateId
                            }); ;
                            _electionDetailRepository.SaveAsync();
                        }
                    }

                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback(); 
                }
            }
        }
    }
}
