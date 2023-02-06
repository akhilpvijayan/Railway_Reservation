using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using railwayReservation.Business.DataServices;
using railwayReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Business.Services.DataServices
{
    public class TicketDataService : ITicketDataService
    {
        #region Private Functions
        private readonly ApplicationDBContext _applicationDbContext;
        #endregion
        #region Constructor
        public TicketDataService(ApplicationDBContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        #endregion
        #region Public Functions
        public IEnumerable<Tickets> GetAllTickets()
        {
            return _applicationDbContext.Tickets.ToList();
        }

        public IEnumerable<Tickets> GetTicket(int ticketId)
        {
            return _applicationDbContext.Tickets.Where(s=>s.ticketId==ticketId);
        }  

        public IEnumerable<Tickets> AddTicket([FromBody] Tickets ticket)
        {
            _applicationDbContext.Tickets.Add(ticket);
            _applicationDbContext.SaveChanges();
            return GetTicket(ticket.ticketId);
        }
        #endregion

    }
}
