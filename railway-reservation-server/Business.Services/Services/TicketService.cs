using railwayReservation.Business.DataServices;
using railwayReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Business.Services.Services
{
    public class TicketService : ITicketService
    {
        #region Private Functions
        private readonly ITicketDataService _ticketDataService;
        #endregion
        #region Constructor
        public TicketService(ITicketDataService ticketDataService)
        {
            _ticketDataService = ticketDataService;
        }
        #endregion
        #region Public Functions
        public IEnumerable<Tickets> GetAllTickets()
        {
            return _ticketDataService.GetAllTickets();
        }

        public IEnumerable<Tickets> GetTicket(int ticketId)
        {
            return _ticketDataService.GetTicket(ticketId);
        }

        public IEnumerable<Tickets> AddTicket(Tickets ticket)
        {
            ticket.userId = 2;
            return _ticketDataService.AddTicket(ticket);
        }
        #endregion
    }
}
