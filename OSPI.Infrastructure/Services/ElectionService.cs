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
    public class ElectionService : IElectionService
    {
        private readonly ApplicationDbContext _context; 
        private readonly IElectionRepository _electionRepository;
        private readonly IPositionRepository _positionRepository;
        private readonly IMapper _mapper;

        public ElectionService(ApplicationDbContext context, IElectionRepository electionRepository, IPositionRepository positionRepository, IMapper mapper)
        {
            _context = context;
            _electionRepository = electionRepository;
            _positionRepository = positionRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(ElectionModel election)
        {
            //using (var transaction = _context.Database.BeginTransaction())
            using (var transaction = new TransactionScope())
            {
                try
                {
                    _electionRepository.Create(_mapper.Map<ElectionEntity>(election));
                    _electionRepository.SaveAsync().ConfigureAwait(false);

                    foreach (var item in election.JPositions)
                    {
                        PositionEntity positionEntity = new PositionEntity
                        {
                            PositionID = Guid.NewGuid(),
                            PositionName = item.PositionName,
                            RequiredCandidates = item.RequiredCandidates,
                            Qualifications = item.Qualifications,
                            ElectionID = election.ElectionID
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

        public async Task DeleteAsync(ElectionModel election)
        {
            this._electionRepository.Delete(await _electionRepository.GetByIdAsync(election.ElectionID));
            await _electionRepository.SaveAsync();
        }

        public async Task<IEnumerable<ElectionModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<ElectionModel>>(await _electionRepository.GetAllAsync());

        public async Task<ElectionModel> GetByIdAsync(Guid? id)
            => _mapper.Map<ElectionModel>(await _electionRepository.GetByIdAsync(id));

        public async Task UpdateAsync(ElectionModel election)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    _electionRepository.Update(_mapper.Map<ElectionEntity>(election));
                    _electionRepository.SaveAsync();

                    foreach (var item in election.JPositions)
                    {
                        PositionEntity positionEntity = new PositionEntity
                        {
                            PositionID = Guid.NewGuid(),
                            PositionName = item.PositionName,
                            RequiredCandidates = item.RequiredCandidates,
                            Qualifications = item.Qualifications,
                            ElectionID = election.ElectionID
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
    }
}
