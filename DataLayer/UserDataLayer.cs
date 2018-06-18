using System.Collections.Generic;
using Entities;

namespace DataLayer
{
    public class UserDataLayer : IUserDataLayer
    {
        private List<User> Users => new List<User>
        {
            new User{Id = 1, FirstName = "Hung", LastName = "Nguyen", UserName = "hungnguyen", Password = "123456"},
            new User{Id = 2, FirstName = "Thang", LastName = "Nguyen", UserName = "thangnguyen", Password = "123456"},
            new User{Id = 3, FirstName = "Hai", LastName = "Tran", UserName = "haitran", Password = "123456"}
        };

        public IEnumerable<User> GetAllUsers()
        {
            return Users;
        }
    }
}
