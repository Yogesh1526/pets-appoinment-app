using HealingPaws.DataAccess.Context;
using HealingPaws.DataAccess.Entities;
using HealingPaws.DataAccess.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HealingPaws.DataAccess.IRepositories;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    protected readonly ApplicationDbContext _context;
    protected readonly DbSet<T> _dbSet;
    
    public Repository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }
    public virtual async Task<T> GetByIdAsync(int id, Expression<Func<T, object>>[] includeProperties)
    {
        var query = _dbSet.AsNoTracking();
        if (includeProperties != null && includeProperties.Any())
        {
            query = query.IncludeProperties(includeProperties);
        }
        return await query.FirstOrDefaultAsync(e => e.Id == id);
    }
    public virtual async Task<T> GetByIdWithNoIncludeAsync(int id)
    {
        var query = _dbSet.AsNoTracking();
        return await query.FirstOrDefaultAsync(e => e.Id == id);
    }

    public virtual async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, object>>[] includeProperties)
    {
        var query = _dbSet.AsNoTracking();
        if (includeProperties != null && includeProperties.Any())
        {
            query = query.IncludeProperties(includeProperties);
        }
        return await query.ToListAsync();
    }

    public virtual async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
    {
        return await _dbSet.AsNoTracking().Where(predicate).ToListAsync();
    }

    public virtual async Task<T> CreateAsync(T entity)
    {
        entity.CreatedDate = DateTime.Now;
        entity.CreatedBy = "admin";
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public virtual async Task<bool> UpdateAsync(T entity)
    {
        entity.UpdatedDate = DateTime.Now;
        entity.UpdatedBy = "admin";
        _dbSet.Update(entity);
        return await _context.SaveChangesAsync() > 0;
    }

    public virtual async Task<bool> RemoveAsync(T entity)
    {
        _dbSet.Remove(entity);
        return await _context.SaveChangesAsync() > 0;
    }
}
