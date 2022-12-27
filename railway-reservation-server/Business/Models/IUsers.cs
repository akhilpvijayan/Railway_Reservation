using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Business.Models
{
    public interface IUsers
    {
        int userId { get; set; }
        string firstName { get; set; }
        string lastName { get; set; }
        string userAddress { get; set; }
        string userName { get; set; }
        string userPassword { get; set; }
        string userGender { get; set; }
        int userAge { get; set; }
        string userEmail { get; set; }
        long userAadhar { get; set; }
        long userMobile { get; set; }
        string userCity { get; set; }
        string userState { get; set; }
        long userPin { get; set; }
    }
}
