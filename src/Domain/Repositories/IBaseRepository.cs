using Domain.Entities;

namespace Domain.Repositories;

public interface IBaseRepository<TEntity> where TEntity : BaseEntity
{
    Task<TEntity?> GetByIdAsync(int id);
    
    //TODO: add pages on get all
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<int> AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
}