using System.Collections.Generic;
using DataLayer;
using Entities;

namespace ServiceLayer
{
    public class UserServiceLayer : IUserServiceLayer
    {
        private readonly IUserDataLayer _userDataLayer;

        public UserServiceLayer(IUserDataLayer userDataLayer)
        {
            _userDataLayer = userDataLayer;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userDataLayer.GetAllUsers();
        }
    }
}
