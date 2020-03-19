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
    public class CandidateService : ICandidateService
    {
        private readonly ICandidateRepository _candidateRepository;
        private readonly IPositionRepository _positionRepository;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public CandidateService(ICandidateRepository candidateRepository, IPositionRepository positionRepository, IConfiguration configuration, IMapper mapper, ApplicationDbContext context)
        {
            _candidateRepository = candidateRepository;
            _positionRepository = positionRepository;
            _configuration = configuration;
            _mapper = mapper;
            _context = context;
        }

        public async Task CreateAsync(CandidateModel candidate)
        {
            _candidateRepository.Create(_mapper.Map<CandidateEntity>(candidate));
            await _candidateRepository.SaveAsync();
        }

        public async Task UpdateAsync(CandidateModel candidate)
        {
            try
            {
                _candidateRepository.Update(_mapper.Map<CandidateEntity>(candidate));
                await _candidateRepository.SaveAsync();
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public async Task UpdateStatusAsync(Guid id, string status)
        {
            try
            {
                var entry = await _context.Candidates.FindAsync(id);
                entry.Status = status;
                _context.Candidates.Update(_mapper.Map<CandidateEntity>(entry));
                _context.Save();
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public async Task DeleteAsync(CandidateModel candidate)
        {
            this._candidateRepository.Delete(await _candidateRepository.GetByIdAsync(candidate.CandidateId));
            await _candidateRepository.SaveAsync();
        }

        public async Task<CandidateModel> GetByIdAsync(Guid? id)
            => _mapper.Map<CandidateModel>(await _candidateRepository.GetByIdAsync(id));
        public async Task<IEnumerable<CandidateModel>> GetAllByNomineeIdAsync(Guid? id)
            => _mapper.Map<IEnumerable<CandidateModel>>(await _candidateRepository.GetAllByNomineeIdAsync(id));
        public async Task<IEnumerable<CandidateModel>> GetAllCandidatesAsync(Guid? ballotId, string status) => _mapper.Map<IEnumerable<CandidateModel>>(await _candidateRepository.GetAllCandidatesAsync(ballotId, status));
        public async Task<IEnumerable<CandidateModel>> GetAllByPositionIdAsync(Guid? positionId, string status)
            => _mapper.Map<IEnumerable<CandidateModel>>(await _candidateRepository.GetAllByPositionIdAsync(positionId, status));
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
                    PositionId = position.PositionId.ToString(),
                    PositionName = position.PositionName,
                    MinimumVotes = position.MinimumRequiredVotes,
                    MaximumVotes = position.MaximumRequiredVotes,
                    Candidates = new List<CCandidateModel>()
                };

                ccandidates = await _candidateRepository.GetAllByPositionIdAsync(position.PositionId, status);

                foreach (CandidateEntity candidateEntity in ccandidates)
                {
                    CCandidateModel cCandidateModel = new CCandidateModel
                    {
                        CandidateId = candidateEntity.CandidateId,
                        CandidateName = candidateEntity.CandidateMember.FirstName + " " + candidateEntity.CandidateMember.LastName,
                        MemberId = candidateEntity.CandidateMemberId.ToString()
                    };

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

                positions.Add(cPositionModel);
            }

            return positions;
        }
        public async Task<IEnumerable<CandidateModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<CandidateModel>>(await _candidateRepository.GetAllAsync());







    }
}
