using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Models
{
    public static class SeedDataExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Seats
            modelBuilder.Entity<Seats>()
                .HasData(
                new Seats { seatTypeId = 1 , seatType = "AC", fare = 85 },
                new Seats { seatTypeId = 2 , seatType = "Sleeper", fare = 55 },
                new Seats { seatTypeId = 3 , seatType = "SemiSleeper", fare = 45 },
                new Seats { seatTypeId = 4 , seatType = "General", fare = 25 }
            );

            //Users
            modelBuilder.Entity<Users>()
            .HasData(
                new Users { userId = 1, firstName = "superuser", lastName = "", userAddress = "", userName = "superuser", userPassword = "superuser", userGender = "Male", userAge = 25, userEmail = "superuser@yahoo.com", userAadhar = 839292029087, userMobile = 9876178281, userCity = "Toronto", userState = "Ontario", userPin = 7382820},
                new Users { userId = 2, firstName = "John", lastName = "Blake", userAddress = "", userName = "john", userPassword = "john", userGender = "Male", userAge = 65, userEmail = "john@yahoo.com", userAadhar = 839126729087, userMobile = 1267178281, userCity = "Calgary", userState = "British Columbia", userPin = 256718983 }
            );

            //Trains
            modelBuilder.Entity<Trains>()
            .HasData(
                new Trains { trainId = 1 , trainName = "The Ambassador" , source = "1" , destination = "2" , ACSeats  = 25 , generalSeats = 50, semiSleeperSeats = 48, sleeperSeats = 40, trainType = "2"},
                new Trains { trainId = 2, trainName = "Chaleur", source = "2", destination = "3", ACSeats = 15, generalSeats = 52, semiSleeperSeats = 18, sleeperSeats = 10, trainType = "4" },
                new Trains { trainId = 3, trainName = "Flying Bluenose", source = "3", destination = "4", ACSeats = 15, generalSeats = 52, semiSleeperSeats = 18, sleeperSeats = 10, trainType = "5" },
                new Trains { trainId = 4, trainName = "The Gull", source = "1", destination = "4", ACSeats = 15, generalSeats = 52, semiSleeperSeats = 18, sleeperSeats = 10, trainType = "6" },
                new Trains { trainId = 5, trainName = "Montreal", source = "2", destination = "6", ACSeats = 15, generalSeats = 52, semiSleeperSeats = 18, sleeperSeats = 10, trainType = "3" },
                new Trains { trainId = 6, trainName = "Owl", source = "5", destination = "1", ACSeats = 15, generalSeats = 52, semiSleeperSeats = 18, sleeperSeats = 10, trainType = "1" }
                );

            //Tickets
            modelBuilder.Entity<Tickets>()
                .HasData(
                new Tickets { ticketId = 1, ticketNumber = "A6755HI9899", journeyDate = DateTime.Now, bookedDate= DateTime.Today, trainId = 3, ticketFare= 580, ticketStatus = "Confirmed", userId = 2},
                new Tickets { ticketId = 2, ticketNumber = "A67OLPM9899", journeyDate = DateTime.Parse("1/1/2023 12:00:00 AM"), bookedDate = DateTime.Today, trainId = 5, ticketFare = 180, ticketStatus = "Confirmed", userId = 2 }
            );

            //Passengers
            modelBuilder.Entity<Passengers>()
                .HasData(
                new Passengers { passengerId = 1, passengerName = "Kenny", pnrNo = 8762671890, passengerAge = 21, passengerGender = "Female", bookedUser = "2", reservationStatus = "Pending", ticketNumber = "1", seatNumber = "232", startingPoint = "Ontario", destination = "Vancouer", seatClass = "2"},
                new Passengers { passengerId = 2, passengerName = "Robert", pnrNo = 9172817269, passengerAge = 67, passengerGender = "Male", bookedUser = "2", reservationStatus = "Completed", ticketNumber = "2", seatNumber = "988", startingPoint = "Calgary", destination = "Ontario", seatClass = "4"}
            );

            modelBuilder.Entity<TrainTypes>()
                .HasData(
                new TrainTypes { trainTypeId = 1, trainType = "Bullet Train" },
                new TrainTypes { trainTypeId = 2, trainType = "Passenger Train" },
                new TrainTypes { trainTypeId = 3, trainType = "Semi High Speed Train" },
                new TrainTypes { trainTypeId = 4, trainType = "Express Train" },
                new TrainTypes { trainTypeId = 5, trainType = "Luxury Train" },
                new TrainTypes { trainTypeId = 6, trainType = "Super Fast Train" },
                new TrainTypes { trainTypeId = 7, trainType = "Suburban Train" }
            );
            modelBuilder.Entity<Stations>()
                .HasData(
                new Stations { stationId = 1, stationName = "Vancouer"},
                new Stations { stationId = 2, stationName = "Alberta" },
                new Stations { stationId = 3, stationName = "Calgary" },
                new Stations { stationId = 4, stationName = "British Columbia" },
                new Stations { stationId = 5, stationName = "Florida" },
                new Stations { stationId = 6, stationName = "Chicago" },
                new Stations { stationId = 7, stationName = "New Jersey" },
                new Stations { stationId = 8, stationName = "Ontario" },
                new Stations { stationId = 9, stationName = "Seattle" }
            );
        }
    }
}
