using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Business.Models
{
    public interface ISeats
    {
        int seatTypeId { get; set; }
        string seatType { get; set; }
        int fare { get; set; }
    }
}
