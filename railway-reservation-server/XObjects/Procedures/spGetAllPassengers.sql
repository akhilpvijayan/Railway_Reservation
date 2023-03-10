USE [railway-Reservation]
GO
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'GetAllPassengers')
DROP PROCEDURE [GetAllPassengers]

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllPassengers]
        AS
        BEGIN
		    DECLARE @sqlQuery nvarchar(max)
            SET NOCOUNT ON;
								select 
								p.passengerId passengerId,
								p.passengerName passengerName,
								p.pnrNo pnrNo,
								p.passengerAge passengerAge,
								p.passengerGender passengerGender,
								p.reservationStatus reservationStatus,
								p.seatNumber seatNumber,
								p.startingPoint startingPoint,
								p.destination destination,
								p.journeyDate journeyDate,
								(select u.userName from Users u where u.userId = p.bookedUser) bookedUser,
								(select s.seatType from Seats s where s.seatTypeId = p.seatClass) seatClass,
								(select t.ticketNumber from Tickets t where t.ticketId = p.ticketNumber) ticketNumber
								FROM Passengers p
								
        END
GO