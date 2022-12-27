using railwayReservation.Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Models
{
    public class Tickets : ITickets
    {
        [Key]
        public int ticketId { get; set; }
        public string ticketNumber { get; set; }
        public string ticketStatus { get; set; }
        [ForeignKey("bookedUserId")]
        public int userId  { get; set; }
        public DateTime bookedDate { get; set; }
        public DateTime journeyDate { get; set; }
        public int ticketFare { get; set; }
        [ForeignKey("trainsId")]
        public int trainId { get; set; }
        public virtual Users bookedUserId { get; set; }
        public virtual Trains trainsId { get; set; }
    }
}
