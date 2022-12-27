USE [railway-Reservation]
GO
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'spGetUserById')
DROP PROCEDURE [spGetUserById]

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetUserById]
		@userId INT
        AS
        BEGIN
		    DECLARE @sqlQuery nvarchar(max)
            SET NOCOUNT ON;
								select 
								u.userId UserId,
								u.firstName FirstName,
								u.lastName LastName,
								u.userAadhar UserAadhar,
								u.userAddress UserAddress,
								u.userAge UaerAge,
								u.userCity UserCity,
								u.userEmail UserEmail,
								u.userGender UserGender,
								u.userMobile UserMobile,
								u.userName UserName,
								u.userPassword UserPassword,
								u.userPin UserPin,
								u.userState UserState
								FROM Users u where u.userId = @userId
								
        END
GO