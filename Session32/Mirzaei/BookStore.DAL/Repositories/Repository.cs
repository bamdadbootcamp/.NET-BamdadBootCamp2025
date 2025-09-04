using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.DAL.Contexts;
using BookStore.DAL.Contract;
using BookStore.Domain.Core;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected ApplicationDbContext _context;
        protected DbSet<TEntity> _entities { get; }
        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }
        public async Task AddAsync(TEntity entity, CancellationToken cancellationToken)
        {
            await _entities.AddAsync(entity, cancellationToken);            
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken)
        {
            await _entities.AddRangeAsync(entities, cancellationToken);
        }

        public void Delete(TEntity entity)
        {
            _entities.Remove(entity);
        }

        public void DeleteRange(TEntity entity)
        {
            _entities.Remove(entity);
        }


        public async Task<TEntity> GetByIdAsync(long id, CancellationToken cancellationToken)
        {
            var entity = await _entities.FindAsync(cancellationToken, id);
            if (entity == null)
            {
                throw new Exception("Entity not found");
            }
            return entity;
        }

        public void Update(TEntity entity)
        {
            _entities.Update(entity);
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            _entities.UpdateRange(entities);
        }

        public async Task<IQueryable<TEntity>> GetAllAsync(CancellationToken cancellationToken)
        {            
            return _entities;
        }

        public async Task SaveChangesAsync(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
