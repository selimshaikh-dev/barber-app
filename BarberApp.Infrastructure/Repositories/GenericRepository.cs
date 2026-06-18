using BarberApp.Application.Interfaces.Repositories;
using BarberApp.Domain.Common;
using BarberApp.Domain.Entities;
using BarberApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BarberApp.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T : BaseEntity
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync(
            CancellationToken cancellationToken = default)
        {
            return await _dbSet
                .Where(x => x.IsActive)
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }


        public async Task<T?> GetByIdAsync(
            int id,
            CancellationToken cancellationToken = default)
        {
            return await _dbSet
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id && x.IsActive, cancellationToken);
        }


        public async Task<IEnumerable<T>> FindAsync(
            Expression<Func<T, bool>> predicate,
            CancellationToken cancellationToken = default)
        {
            return await _dbSet
                .Where(x => x.IsActive)
                .Where(predicate)
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }


        public async Task<T?> FirstOrDefaultAsync(
            Expression<Func<T, bool>> predicate,
            CancellationToken cancellationToken = default)
        {
            return await _dbSet
                .Where(x => x.IsActive)
                .AsNoTracking()
                .FirstOrDefaultAsync(predicate, cancellationToken);
        }


        public async Task AddAsync(T entity,
            CancellationToken cancellationToken = default)
        {
            entity.IsActive = true;
            entity.CreatedAt = DateTime.UtcNow;

            await _dbSet.AddAsync(entity, cancellationToken);
        }


        public void Update(T entity)
        {
            entity.UpdatedAt = DateTime.UtcNow;

            _dbSet.Update(entity);
        }


        public void Delete(T entity)
        {
            entity.IsActive = false;
            entity.UpdatedAt = DateTime.UtcNow;

            _dbSet.Update(entity);
        }


        public async Task<bool> AnyAsync(
            Expression<Func<T, bool>> predicate,
            CancellationToken cancellationToken = default)
        {
            return await _dbSet
                .AnyAsync(x => x.IsActive && predicate.Compile().Invoke(x), cancellationToken);
        }


        public async Task<int> CountAsync(
            Expression<Func<T, bool>> predicate,
            CancellationToken cancellationToken = default)
        {
            return await _dbSet
                .CountAsync(x => x.IsActive && predicate.Compile().Invoke(x), cancellationToken);
        }


        public async Task<IEnumerable<T>> GetPagedAsync(
            int page,
            int pageSize,
            CancellationToken cancellationToken = default)
        {
            return await _dbSet
                .Where(x => x.IsActive)
                .AsNoTracking()
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync(cancellationToken);
        }
    }
}