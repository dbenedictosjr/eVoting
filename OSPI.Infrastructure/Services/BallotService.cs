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
        private readonly IBallotRepository _electionRepository;
        private readonly IPositionRepository _positionRepository;
        private readonly IMapper _mapper;

        public BallotService(ApplicationDbContext context, IBallotRepository electionRepository, IPositionRepository positionRepository, IMapper mapper)
        {
            _context = context;
            _electionRepository = electionRepository;
            _positionRepository = positionRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(BallotModel election)
        {
            //using (var transaction = _context.Database.BeginTransaction())
            using (var transaction = new TransactionScope())
            {
                try
                {
                    _electionRepository.Create(_mapper.Map<BallotEntity>(election));
                    _electionRepository.SaveAsync().ConfigureAwait(false);

                    foreach (var item in election.JPositions)
                    {
                        PositionEntity positionEntity = new PositionEntity
                        {
                            PositionId = Guid.NewGuid(),
                            PositionName = item.PositionName,
                            MinimumRequiredVotes = item.MinimumRequiredVotes,
                            MaximumRequiredVotes = item.MaximumRequiredVotes,
                            Qualifications = item.Qualifications,
                            BallotId = election.BallotId
                        };

                        _positionRepository.Create(positionEntity);
                        _positionRepository.SaveAsync().ConfigureAwait(false);
                    }
                    //transaction.Commit();
                    transaction.Complete();
                }
                catch (Exception)
                {
                    //transaction.Rollback();
                }
            }
        }

        public async Task DeleteAsync(BallotModel election)
        {
            this._electionRepository.Delete(await _electionRepository.GetByIdAsync(election.BallotId));
            await _electionRepository.SaveAsync();
        }

        public async Task<IEnumerable<BallotModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<BallotModel>>(await _electionRepository.GetAllAsync());

        public async Task<BallotModel> GetByIdAsync(Guid? id)
            => _mapper.Map<BallotModel>(await _electionRepository.GetByIdAsync(id));

        public async Task UpdateAsync(BallotModel election)
        {
            using (var transaction = _context.Database.BeginTransaction())
            //using (var transaction = new TransactionScope())
            {
                try
                {
                    _electionRepository.Update(_mapper.Map<BallotEntity>(election));
                    _electionRepository.SaveAsync();

                    foreach (var item in election.JPositions)
                    {
                        PositionEntity positionEntity = new PositionEntity
                        {
                            PositionId = Guid.NewGuid(),
                            PositionName = item.PositionName,
                            MinimumRequiredVotes = item.MinimumRequiredVotes,
                            MaximumRequiredVotes = item.MaximumRequiredVotes,
                            Qualifications = item.Qualifications,
                            BallotId = election.BallotId
                        };

                        _positionRepository.Create(positionEntity);
                        _positionRepository.SaveAsync().ConfigureAwait(false);
                    }
                    transaction.Commit();
                    //transaction.Complete();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
        }
    }
}
