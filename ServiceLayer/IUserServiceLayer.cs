using System.Collections.Generic;
using Entities;

namespace ServiceLayer
{
    public interface IUserServiceLayer
    {
        IEnumerable<User> GetAllUsers();
    }
}
