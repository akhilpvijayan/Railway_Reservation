using railwayReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Business.Services
{
    public interface IUserService
    {
        IEnumerable<Users> GetAllUsers();
        IEnumerable<Users> AddUser(Users users);
        IEnumerable<Users> GetUser(int userId);
        IEnumerable<Users> UpdateUser(int userId, Users users);
        Task<Users> DeleteUser(int userId);
    }
}
