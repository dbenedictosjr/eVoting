using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Online_Store.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity> GetByIDAsync(Guid? id);

        void Create(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        Task SaveAsync();

        void Dispose();
    }
}
