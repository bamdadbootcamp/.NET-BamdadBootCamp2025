using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Core;

namespace BookStore.DAL.Contract
{
    public interface IRepository<TEntity> where TEntity : BaseEntity 
    {
        Task<TEntity> GetByIdAsync(long id, CancellationToken cancellationToken);
        Task<IQueryable<TEntity>> GetAllAsync(CancellationToken cancellationToken);


        Task AddAsync(TEntity entity, CancellationToken cancellationToken);
        Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken);
                        
        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);

        void Delete(TEntity entity);
        void DeleteRange(TEntity entity);
       
       Task SaveChangesAsync(CancellationToken cancellationToken);
                
    }
}
