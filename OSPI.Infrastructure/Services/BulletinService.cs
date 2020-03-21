using AutoMapper;
using OSPI.Infrastructure.Interfaces;
using OSPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OSPI.Domain.Interfaces;
using OSPI.Domain.Entities;

namespace OSPI.Infrastructure.Services
{
    public class BulletinService : IBulletinService
    {
        private readonly IBulletinRepository _bulletinRepository;
        private readonly IMapper _mapper;

        public BulletinService(IBulletinRepository bulletinRepository, IMapper mapper)
        {
            _bulletinRepository = bulletinRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(BulletinModel bulletin)
        {
            bulletin.BulletinId = Guid.NewGuid();
            _bulletinRepository.Create(_mapper.Map<BulletinEntity>(bulletin));
            await _bulletinRepository.SaveAsync();
        }

        public async Task DeleteAsync(BulletinModel bulletin)
        {
            this._bulletinRepository.Delete(await _bulletinRepository.GetByIdAsync(bulletin.BulletinId));
            await _bulletinRepository.SaveAsync();
        }

        public async Task<IEnumerable<BulletinModel>> GetAllAsync()
            => _mapper.Map<IEnumerable<BulletinModel>>(await _bulletinRepository.GetAllAsync());

        public async Task<BulletinModel> GetByIdAsync(Guid? bulletinId)
            => _mapper.Map<BulletinModel>(await _bulletinRepository.GetByIdAsync(bulletinId));

        public async Task UpdateAsync(BulletinModel bulletin)
        {
            _bulletinRepository.Update(_mapper.Map<BulletinEntity>(bulletin));
            await _bulletinRepository.SaveAsync();
        }
    }
}
