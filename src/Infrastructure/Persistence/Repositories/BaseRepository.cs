using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
{
    protected readonly DbContext _context;

    protected BaseRepository(DbContext context)
    {
        _context = context;
    }

    public async Task<TEntity?> GetByIdAsync(int id)
    {
        var entity = await _context.Set<TEntity>()
            .SingleOrDefaultAsync(x => x.Id == id);

        return entity;
    }

    public Task<IEnumerable<TEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<int> AddAsync(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);
        return await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(TEntity entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
        await _context.SaveChangesAsync();
    }
}