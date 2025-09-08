using Domain.Entities;

namespace Domain.Repositories;

public interface IUserRepository : IBaseRepository<User>
{
    Task<User?> GetByCpfAsync(string cpf);
    Task<User?> GetByEmailAsync(string email);
}