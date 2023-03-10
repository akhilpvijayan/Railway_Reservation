// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using railwayReservation.Models;

namespace railwayReservation.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20221225173057_Added_Migrations3")]
    partial class Added_Migrations3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("railwayReservation.Models.Passengers", b =>
                {
                    b.Property<int>("passengerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("bookedUser")
                        .HasColumnType("int");

                    b.Property<string>("destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("passengerAge")
                        .HasColumnType("int");

                    b.Property<string>("passengerGender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passengerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("pnrNo")
                        .HasColumnType("bigint");

                    b.Property<string>("reservationStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("seatClassId")
                        .HasColumnType("int");

                    b.Property<string>("seatNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("startingPoint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ticketId")
                        .HasColumnType("int");

                    b.HasKey("passengerId");

                    b.HasIndex("seatClassId");

                    b.HasIndex("ticketId");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("railwayReservation.Models.Seats", b =>
                {
                    b.Property<int>("seatTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("fare")
                        .HasColumnType("int");

                    b.Property<string>("seatType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("seatTypeId");

                    b.ToTable("Seats");

                    b.HasData(
                        new
                        {
                            seatTypeId = 1,
                            fare = 85,
                            seatType = "AC"
                        },
                        new
                        {
                            seatTypeId = 2,
                            fare = 55,
                            seatType = "Sleeper"
                        },
                        new
                        {
                            seatTypeId = 3,
                            fare = 45,
                            seatType = "SemiSleeper"
                        },
                        new
                        {
                            seatTypeId = 4,
                            fare = 25,
                            seatType = "General"
                        });
                });

            modelBuilder.Entity("railwayReservation.Models.Stations", b =>
                {
                    b.Property<int>("stationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("arrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("depatureTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("stationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("trainId")
                        .HasColumnType("int");

                    b.HasKey("stationId");

                    b.HasIndex("trainId");

                    b.ToTable("Stations");
                });

            modelBuilder.Entity("railwayReservation.Models.Tickets", b =>
                {
                    b.Property<int>("ticketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("bookedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("journeyDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ticketFare")
                        .HasColumnType("int");

                    b.Property<string>("ticketNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ticketStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("trainId")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("ticketId");

                    b.HasIndex("trainId");

                    b.HasIndex("userId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("railwayReservation.Models.Trains", b =>
                {
                    b.Property<int>("trainId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ACSeats")
                        .HasColumnType("int");

                    b.Property<string>("destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("generalSeats")
                        .HasColumnType("int");

                    b.Property<int>("semiSleeperSeats")
                        .HasColumnType("int");

                    b.Property<int>("sleeperSeats")
                        .HasColumnType("int");

                    b.Property<string>("source")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("trainName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("trainId");

                    b.ToTable("Trains");
                });

            modelBuilder.Entity("railwayReservation.Models.Users", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("userAadhar")
                        .HasColumnType("bigint");

                    b.Property<string>("userAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userAge")
                        .HasColumnType("int");

                    b.Property<string>("userCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userGender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("userMobile")
                        .HasColumnType("bigint");

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("userPin")
                        .HasColumnType("bigint");

                    b.Property<string>("userState")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("railwayReservation.Models.Passengers", b =>
                {
                    b.HasOne("railwayReservation.Models.Seats", "seatClass")
                        .WithMany()
                        .HasForeignKey("seatClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("railwayReservation.Models.Tickets", "ticket")
                        .WithMany()
                        .HasForeignKey("ticketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("seatClass");

                    b.Navigation("ticket");
                });

            modelBuilder.Entity("railwayReservation.Models.Stations", b =>
                {
                    b.HasOne("railwayReservation.Models.Trains", "trainNo")
                        .WithMany()
                        .HasForeignKey("trainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("trainNo");
                });

            modelBuilder.Entity("railwayReservation.Models.Tickets", b =>
                {
                    b.HasOne("railwayReservation.Models.Trains", "trainsId")
                        .WithMany()
                        .HasForeignKey("trainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("railwayReservation.Models.Users", "bookedUserId")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bookedUserId");

                    b.Navigation("trainsId");
                });
#pragma warning restore 612, 618
        }
    }
}
