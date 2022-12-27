using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using railwayReservation.Business.Services;
using railwayReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        #region Private Functions
        private readonly IUserService _userService;
        #endregion

        #region Constructors
        public UserController(
            IUserService userService)
        {
            _userService = userService;
        }
        #endregion

        #region Public Functions
        [HttpGet]
        [Route("Users")]
        [ProducesResponseType(typeof(Users), 200)]
        [ProducesResponseType(404)]
        public IEnumerable<Users> GetAllUsers()
        {
            return _userService.GetAllUsers();
        }

        [HttpGet]
        [Route("Users/{userId}")]
        [ProducesResponseType(typeof(Users), 200)]
        [ProducesResponseType(404)]
        public IEnumerable<Users> GetUser(int userId)
        {
            return _userService.GetUser(userId);
        }

        [HttpPost]
        [Route("Users")]
        [ProducesResponseType(typeof(Users), 200)]
        [ProducesResponseType(404)]
        public IEnumerable<Users> AddUser(Users users)
        {
            return _userService.AddUser(users);
        }

        [HttpPut]
        [Route("Users/{userId}")]
        public IEnumerable<Users> UpdateUser(int userId, Users users)
        {
            return _userService.UpdateUser(userId, users);
        }

        [HttpDelete]
        [Route("Users/{userId}")]
        public Task<Users> DeleteUser(int userId)
        {
            return _userService.DeleteUser(userId);
        }
        #endregion
    }
}
