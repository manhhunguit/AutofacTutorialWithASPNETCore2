using System.Collections.Generic;
using Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;

namespace ApiLayer.Controllers
{
    [Produces("application/json")]
    [Route("api/Users")]
    public class UserController : Controller
    {
        private readonly IUserServiceLayer _userServiceLayer;

        public UserController(IUserServiceLayer userServiceLayer)
        {
            _userServiceLayer = userServiceLayer;
        }

        [HttpGet]
        public IEnumerable<User> GetAllUsers()
        {
            return _userServiceLayer.GetAllUsers();
        }
    }
}