using Domain.Entities;

namespace Domain.Interfaces;

public interface IUser : IGenericRepository<User>
{
      Task<User> GetByUserNameAsync (string userName);
}