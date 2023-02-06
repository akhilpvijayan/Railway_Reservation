using railwayReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Business.DataServices
{
    public interface ITicketDataService
    {
        IEnumerable<Tickets> GetAllTickets();
        IEnumerable<Tickets> AddTicket(Tickets tickets);
        IEnumerable<Tickets> GetTicket(int ticketId);
    }
}
