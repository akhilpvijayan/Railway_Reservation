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
                new Trains { trainId = 1 , trainName = "The Ambassador" , source = "Seattle" , destination = "Vancouer" , ACSeats  = 25 , generalSeats = 50, semiSleeperSeats = 48, sleeperSeats = 40},
                new Trains { trainId = 2, trainName = "Chaleur", source = "Montreal", destination = "Gaspe", ACSeats = 15, generalSeats = 52, semiSleeperSeats = 18, sleeperSeats = 10 },
                new Trains { trainId = 3, trainName = "Flying Bluenose", source = "Halifax", destination = "Yarmouth", ACSeats = 15, generalSeats = 52, semiSleeperSeats = 18, sleeperSeats = 10 },
                new Trains { trainId = 4, trainName = "The Gull", source = "Halifax", destination = "Boston", ACSeats = 15, generalSeats = 52, semiSleeperSeats = 18, sleeperSeats = 10 },
                new Trains { trainId = 5, trainName = "Montreal", source = "Montreal", destination = "Quebec City", ACSeats = 15, generalSeats = 52, semiSleeperSeats = 18, sleeperSeats = 10 },
                new Trains { trainId = 6, trainName = "Owl", source = "Vancouer", destination = "Portland", ACSeats = 15, generalSeats = 52, semiSleeperSeats = 18, sleeperSeats = 10 }
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
        }
    }
}
