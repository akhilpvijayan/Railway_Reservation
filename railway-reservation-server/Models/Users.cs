using railwayReservation.Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Models
{
    public class Users : IUsers
    {
        [Key]
        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userAddress { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string userGender { get; set; }
        public int userAge { get; set; }
        public string userEmail { get; set; }
        public long userAadhar { get; set; }
        public long userMobile { get; set; }
        public string userCity { get; set; }
        public string userState { get; set; }
        public long userPin { get; set; }
    }
}
