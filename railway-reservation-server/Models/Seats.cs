using railwayReservation.Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Models
{
    public class Seats : ISeats
    {
        [Key]
        public int seatTypeId { get; set; }
        public string seatType { get; set; }
        public int fare { get; set; }
    }
}
