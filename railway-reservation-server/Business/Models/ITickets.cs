using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Business.Models
{
    public interface ITickets
    {
        int ticketId { get; set; }
        string ticketNumber { get; set; }
        string ticketStatus { get; set; }
        int userId { get; set; }
        DateTime bookedDate { get; set; }
        DateTime journeyDate { get; set; }
        int ticketFare { get; set; }
    }
}
