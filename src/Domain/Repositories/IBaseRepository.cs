using Domain.Entities;

namespace Domain.Repositories;

public interface IBaseRepository<TEntity> where TEntity : BaseEntity
{
    Task<TEntity?> GetByIdAsync(int id);
    Task<TEntity?> GetByCpfAsync(string cpf);
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<int> AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
}