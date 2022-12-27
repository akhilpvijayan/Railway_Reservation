using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Business.Models
{
    public interface IPassengers
    {
        int passengerId { get; set; }
        string passengerName { get; set; }
        long pnrNo { get; set; }
        int passengerAge { get; set; }
        string passengerGender { get; set; }
        string bookedUser { get; set; }
        string reservationStatus { get; set; }
        string seatNumber { get; set; }
        string ticketNumber { get; set; }
        string startingPoint { get; set; }
        string destination { get; set; }
        string seatClass { get; set; }
    }
}
