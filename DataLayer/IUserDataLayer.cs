using System.Collections.Generic;
using Entities;

namespace DataLayer
{
    public interface IUserDataLayer
    {
        IEnumerable<User> GetAllUsers();
    }
}
