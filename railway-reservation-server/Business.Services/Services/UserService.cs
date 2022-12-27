using railwayReservation.Business.DataServices;
using railwayReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Business.Services.Services
{
    public class UserService : IUserService
    {
        #region Private Functions
        private readonly IUserDataService _userDataService;
        #endregion
        #region Constructor
        public UserService(IUserDataService userDataService)
        {
            _userDataService = userDataService;
        }
        #endregion
        #region Public Functions
        public IEnumerable<Users> GetAllUsers()
        {
            return _userDataService.GetAllUsers();
        }

        public IEnumerable<Users> GetUser(int userId)
        {
            return _userDataService.GetUser(userId);
        }

        public IEnumerable<Users> AddUser(Users users)
        {
            return _userDataService.AddUser(users);
        }
        public IEnumerable<Users> UpdateUser(int userId, Users users)
        {
            return _userDataService.UpdateUser(userId, users);
        }
        public Task<Users> DeleteUser(int userId)
        {
            return _userDataService.DeleteUser(userId);
        }
        #endregion
    }
}
