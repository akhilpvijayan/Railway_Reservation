using Microsoft.AspNetCore.Mvc;
using railwayReservation.Business.DataServices;
using railwayReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace railwayReservation.Business.Services.DataServices
{
    public class PassengerDataService : IPassengerDataService
    {
        #region Private Functions
        private readonly ApplicationDBContext _applicationDbContext;
        #endregion
        #region Constructor
        public PassengerDataService(ApplicationDBContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        #endregion
        #region Public Functions
        public IEnumerable<Passengers> GetAllPassengers()
        {
            return _applicationDbContext.Passengers.FromSqlRaw("GetAllPassengers");
            //return _applicationDbContext.Passengers.ToList();
        }

        public IEnumerable<Passengers> GetPassenger(int passengerId)
        {
            return _applicationDbContext.Passengers.FromSqlRaw("GetPassengerById {0}" ,passengerId);
        }

        public IEnumerable<Passengers> AddPassenger([FromBody] Passengers passengers)
        {
             _applicationDbContext.Passengers.Add(passengers);
            _applicationDbContext.SaveChanges();
            return GetPassenger(passengers.passengerId);
        }

        public IEnumerable<Passengers> UpdatePassenger(int passengerId, Passengers passengers)
        {
            var passenger = _applicationDbContext.Passengers.Find(passengerId);
            if(passenger != null)
            {
                passengers.passengerId = passengers.passengerId;
                passenger.passengerName = passengers.passengerName;
                passenger.passengerAge = passengers.passengerAge;
                passenger.passengerGender = passengers.passengerGender;
                passenger.pnrNo = passengers.pnrNo;
                passenger.bookedUser = passengers.bookedUser;
                passenger.reservationStatus = passengers.reservationStatus;
                passenger.seatNumber = passengers.seatNumber;
                passenger.seatClass = passengers.seatClass;
                passenger.ticketNumber = passengers.ticketNumber;
                passenger.startingPoint = passengers.startingPoint;
                passenger.destination = passengers.destination;
                _applicationDbContext.SaveChanges();
                return GetPassenger(passengers.passengerId);
            }
            return null;
        }

        public async Task<Passengers> DeletePassenger(int passengerId)
        {
            var result = await _applicationDbContext.Passengers.FirstOrDefaultAsync(e => e.passengerId == passengerId);
            if (result != null)
            {
                _applicationDbContext.Passengers.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
        #endregion
    }
}
