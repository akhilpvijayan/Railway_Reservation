using railwayReservation.Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Models
{
    public class Passengers : IPassengers
    {
        [Key]
        public int passengerId { get; set; }
        public string passengerName { get; set; }
        public long pnrNo { get; set; }
        public int passengerAge { get; set; }
        public string passengerGender { get; set; }
        public string bookedUser { get; set; }
        public string reservationStatus { get; set; }
        public string seatNumber { get; set; }
        //[ForeignKey("ticket")]
        public string ticketNumber { get; set; }
        //public virtual Tickets ticket { get; set; }
        public string startingPoint { get; set; }
        public string destination { get; set; }
        //[ForeignKey("seatClassId")]
        public string seatClass { get; set; }
        public DateTime journeyDate { get; set; }
        // public virtual Seats seatClassId { get; set; }
    }
}
