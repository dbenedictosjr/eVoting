using AutoMapper;
using Microsoft.Extensions.Configuration;
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
        private readonly ICandidateRepository _candidateRepository;
        private readonly IMemberRepository _memberRepository;
        private readonly IPositionRepository _positionRepository;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public ElectionService(ApplicationDbContext context, IElectionRepository electionRepository, IElectionDetailRepository electionDetailRepository, ICandidateRepository candidateRepository, IMemberRepository memberRepository, IPositionRepository positionRepository, IConfiguration configuration, IMapper mapper)
        {
            _context = context;
            _electionRepository = electionRepository;
            _electionDetailRepository = electionDetailRepository;
            _candidateRepository = candidateRepository;
            _memberRepository = memberRepository;
            _positionRepository = positionRepository;
            _configuration = configuration;
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

        public async Task<List<CPositionModel>> GetAllPositionAsync(Guid? ballotId, string status)
        {
            List<CPositionModel> positions = new List<CPositionModel>();
            IEnumerable<CandidateEntity> ccandidates;
            IEnumerable<PositionEntity> cpositions = await _positionRepository.GetAllByBallotIdAsync(ballotId);
            var rootpath = _configuration["RootMemberImagePath"];
            var displaypath = _configuration["MemberImagePath"];
            foreach (PositionEntity position in cpositions)
            {
                CPositionModel cPositionModel = new CPositionModel
                {
                    PositionId = position.PositionId,
                    PositionName = position.PositionName,
                    MinimumVotes = position.MinimumRequiredVotes,
                    MaximumVotes = position.MaximumRequiredVotes,
                    Candidates = new List<CCandidateModel>()
                };

                ccandidates = await _candidateRepository.GetAllByPositionIdAsync(position.PositionId, status);

                int totalvotes = 0;

                foreach (CandidateEntity candidateEntity in ccandidates)
                {
                    CCandidateModel cCandidateModel = new CCandidateModel
                    {
                        CandidateId = candidateEntity.CandidateId,
                        CandidateName = candidateEntity.CandidateMember.FirstName + " " + candidateEntity.CandidateMember.LastName,
                        MemberId = candidateEntity.CandidateMemberId.ToString(),
                        TotalVotes = (candidateEntity.Votes == null ? 0 : candidateEntity.Votes.Count)
                    };

                    totalvotes += cCandidateModel.TotalVotes;

                    string PNGfilePath = rootpath + "/" + candidateEntity.CandidateMember.MemberNo + "" + ".png";
                    string JpgfilePath = rootpath + "/" + candidateEntity.CandidateMember.MemberNo + "" + ".jpg";

                    if (System.IO.File.Exists(PNGfilePath))
                    {

                        cCandidateModel.MemberNumber = displaypath + "/" + candidateEntity.CandidateMember.MemberNo + "" + ".png";
                    }
                    else if (System.IO.File.Exists(JpgfilePath))
                    {
                        cCandidateModel.MemberNumber = displaypath + "/" + candidateEntity.CandidateMember.MemberNo + "" + ".jpg";
                    }
                    else
                    {
                        cCandidateModel.MemberNumber = _configuration["MemberImagePath"] + "/" + "default.png";
                    }

                    cPositionModel.Candidates.Add(cCandidateModel);
                }

                foreach (CCandidateModel cCandidateModel in cPositionModel.Candidates)
                {
                    cCandidateModel.Percentage = cCandidateModel.TotalVotes / totalvotes;
                }

                positions.Add(cPositionModel);
            }

            return positions;
        }
    }
}
