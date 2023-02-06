using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using railwayReservation.Business.Services;
using railwayReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Controllers
{
    [ApiController]
    public class TicketController : ControllerBase
    {
        #region Private Functions
        private readonly ITicketService _ticketService;
        #endregion

        #region Constructors
        public TicketController(
            ITicketService ticketService)
        {
            _ticketService = ticketService;
        }
        #endregion

        #region Public Functions
        [HttpGet]
        [Route("Tickets")]
        [ProducesResponseType(typeof(Passengers), 200)]
        [ProducesResponseType(404)]
        public IEnumerable<Tickets> GetAllTickets()
        {
            return _ticketService.GetAllTickets();
        }

        [HttpGet]
        [Route("Tickets/{ticketId}")]
        [ProducesResponseType(typeof(Tickets), 200)]
        [ProducesResponseType(404)]
        public IEnumerable<Tickets> GetTicket(int ticketId)
        {
            return _ticketService.GetTicket(ticketId);
        }

        [HttpPost]
        [Route("Tickets")]
        [ProducesResponseType(typeof(Passengers), 200)]
        [ProducesResponseType(404)]
        public IEnumerable<Tickets> AddTicket(Tickets tickets)
        {
            return _ticketService.AddTicket(tickets);
        }
        #endregion
    }
}
