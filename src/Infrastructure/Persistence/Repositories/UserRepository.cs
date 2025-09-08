using Domain.Entities;
using Domain.Repositories;

namespace Infrastructure.Persistence.Repositories;

public class UserRepository(ApplicationDbContext dbContext) : BaseRepository<User>(dbContext), IUserRepository
{
    public Task<User?> GetByCpfAsync(string cpf)
    {
        throw new NotImplementedException();
    }

    public Task<User?> GetByEmailAsync(string email)
    {
        throw new NotImplementedException();
    }
}