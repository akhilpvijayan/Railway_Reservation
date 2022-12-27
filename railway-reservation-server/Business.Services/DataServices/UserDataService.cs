using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using railwayReservation.Business.DataServices;
using railwayReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Business.Services.DataServices
{
    public class UserDataService : IUserDataService
    {

        #region Private Functions
        private readonly ApplicationDBContext _applicationDbContext;
        #endregion
        #region Constructor
        public UserDataService(ApplicationDBContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        #endregion
        #region Public Functions
        public IEnumerable<Users> GetAllUsers()
        {
            //return _applicationDbContext.Users.FromSqlRaw("GetAllPassengers");
            return _applicationDbContext.Users.ToList();
        }

        public IEnumerable<Users> GetUser(int userId)
        {
            return _applicationDbContext.Users.FromSqlRaw("spGetUserById {0}", userId);
        }

        public IEnumerable<Users> AddUser([FromBody] Users users)
        {
            _applicationDbContext.Users.Add(users);
            _applicationDbContext.SaveChanges();
            return GetUser(users.userId);
        }

        public IEnumerable<Users> UpdateUser(int userId, Users users)
        {
            var user = _applicationDbContext.Users.Find(userId);
            if (user != null)
            {

                _applicationDbContext.SaveChanges();
                return GetUser(users.userId);
            }
            return null;
        }

        public async Task<Users> DeleteUser(int userId)
        {
            var result = await _applicationDbContext.Users.FirstOrDefaultAsync(e => e.userId == userId);
            if (result != null)
            {
                _applicationDbContext.Users.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
        #endregion
    }
}
