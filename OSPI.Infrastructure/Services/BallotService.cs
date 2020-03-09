using AutoMapper;
using OSPI.Domain;
using OSPI.Domain.Entities;
using OSPI.Domain.Interfaces;
using OSPI.Infrastructure.Interfaces;
using OSPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Transactions;

namespace OSPI.Infrastructure.Services
{
    public class BallotService : IBallotService
    {
        private readonly ApplicationDbContext _context; 
        private readonly IBallotRepository _ballotRepository;
        private readonly IPositionRepository _positionRepository;
        private readonly IMapper _mapper;

        public BallotService(ApplicationDbContext context, IBallotRepository ballotRepository, IPositionRepository positionRepository, IMapper mapper)
        {
            _context = context;
            _ballotRepository = ballotRepository;
            _positionRepository = positionRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(BallotModel ballot)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _ballotRepository.Create(_mapper.Map<BallotEntity>(ballot));
                    _ballotRepository.SaveAsync();

                    foreach (var item in ballot.JPositions)
                    {
                        PositionEntity positionEntity = new PositionEntity
                        {
                            PositionId = Guid.NewGuid(),
                            PositionName = item.PositionName,
                            MinimumRequiredVotes = item.MinimumRequiredVotes,
                            MaximumRequiredVotes = item.MaximumRequiredVotes,
                            Qualifications = item.Qualifications,
                            BallotId = ballot.BallotId
                        };

                        _positionRepository.Create(positionEntity);
                        _positionRepository.SaveAsync();
                    }
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
        }

        public async Task DeleteAsync(BallotModel ballot)
        {
            this._ballotRepository.Delete(await _ballotRepository.GetByIdAsync(ballot.BallotId));
            await _ballotRepository.SaveAsync();
        }

        public async Task<IEnumerable<BallotModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<BallotModel>>(await _ballotRepository.GetAllAsync());

        public async Task<BallotModel> GetByIdAsync(Guid? id)
            => _mapper.Map<BallotModel>(await _ballotRepository.GetByIdAsync(id));

        public async Task UpdateAsync(BallotModel ballot)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _ballotRepository.Update(_mapper.Map<BallotEntity>(ballot));
                    _ballotRepository.SaveAsync();

                    foreach (var item in ballot.JPositions)
                    {

                        PositionEntity positionEntity = new PositionEntity
                        {
                            PositionId = Guid.NewGuid(),
                            PositionName = item.PositionName,
                            MinimumRequiredVotes = item.MinimumRequiredVotes,
                            MaximumRequiredVotes = item.MaximumRequiredVotes,
                            Qualifications = item.Qualifications,
                            BallotId = ballot.BallotId
                        };

                        _positionRepository.Create(positionEntity);
                        _positionRepository.SaveAsync();
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
