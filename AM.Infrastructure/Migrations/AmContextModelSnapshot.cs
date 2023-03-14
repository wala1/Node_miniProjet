﻿// <auto-generated />
using System;
using AM.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    [DbContext(typeof(AmContext))]
    partial class AmContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AM.ApplicationCore.Domain.Flight", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FlightId"));

                    b.Property<string>("Departure")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("EffectiveArrival")
                        .HasColumnType("date");

                    b.Property<int>("EstimatedDuration")
                        .HasColumnType("int");

                    b.Property<DateTime>("FlightDate")
                        .HasColumnType("date");

                    b.Property<int?>("PlaneFk")
                        .HasColumnType("int");

                    b.HasKey("FlightId");

                    b.HasIndex("PlaneFk");

                    b.ToTable("Vols", (string)null);
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Passenger", b =>
                {
                    b.Property<string>("PassportNumber")
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("EmailAddress")
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<int>("PassengerId")
                        .HasColumnType("int");

                    b.Property<int?>("TelNumber")
                        .HasColumnType("int");

                    b.HasKey("PassportNumber");

                    b.ToTable("Passengers", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Plane", b =>
                {
                    b.Property<int>("PlaneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlaneId"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int")
                        .HasColumnName("PlaneCapacity");

                    b.Property<DateTime>("ManufactureDate")
                        .HasColumnType("date");

                    b.Property<int>("PlaneType")
                        .HasColumnType("int");

                    b.HasKey("PlaneId");

                    b.ToTable("MyPlanes", (string)null);
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Reservation", b =>
                {
                    b.Property<string>("PassengerFk")
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<int>("SeatFk")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateReservation")
                        .HasColumnType("date");

                    b.HasKey("PassengerFk", "SeatFk", "DateReservation");

                    b.HasIndex("SeatFk");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Seat", b =>
                {
                    b.Property<int>("SeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SeatId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<int>("PlaneId")
                        .HasColumnType("int");

                    b.Property<string>("SeatNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<int?>("SectionFk")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("SeatId");

                    b.HasIndex("PlaneId");

                    b.HasIndex("SectionFk");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Section", b =>
                {
                    b.Property<int>("IdSection")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSection"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.HasKey("IdSection");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Ticket", b =>
                {
                    b.Property<int>("FlightFk")
                        .HasColumnType("int");

                    b.Property<string>("PassengerFk")
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<double>("Prix")
                        .HasPrecision(3, 2)
                        .HasColumnType("float(3)");

                    b.Property<string>("Siege")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<bool>("VIP")
                        .HasColumnType("bit");

                    b.HasKey("FlightFk", "PassengerFk");

                    b.HasIndex("PassengerFk");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Staff", b =>
                {
                    b.HasBaseType("AM.ApplicationCore.Domain.Passenger");

                    b.Property<DateTime>("EmployementDate")
                        .HasColumnType("date");

                    b.Property<string>("Function")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<float>("Salary")
                        .HasColumnType("real");

                    b.ToTable("Staffs", (string)null);
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Traveller", b =>
                {
                    b.HasBaseType("AM.ApplicationCore.Domain.Passenger");

                    b.Property<string>("HealthInformation")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.ToTable("Travellers", (string)null);
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Flight", b =>
                {
                    b.HasOne("AM.ApplicationCore.Domain.Plane", "Plane")
                        .WithMany("Flights")
                        .HasForeignKey("PlaneFk")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Plane");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Passenger", b =>
                {
                    b.OwnsOne("AM.ApplicationCore.Domain.FullName", "FullName", b1 =>
                        {
                            b1.Property<string>("PassengerPassportNumber")
                                .HasMaxLength(100)
                                .HasColumnType("varchar");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(30)
                                .HasColumnType("char")
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(30)
                                .HasColumnType("char")
                                .HasColumnName("PassLastName");

                            b1.HasKey("PassengerPassportNumber");

                            b1.ToTable("Passengers");

                            b1.WithOwner()
                                .HasForeignKey("PassengerPassportNumber");
                        });

                    b.Navigation("FullName")
                        .IsRequired();
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Reservation", b =>
                {
                    b.HasOne("AM.ApplicationCore.Domain.Passenger", "Passenger")
                        .WithMany("Reservations")
                        .HasForeignKey("PassengerFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AM.ApplicationCore.Domain.Seat", "Seat")
                        .WithMany("Reservations")
                        .HasForeignKey("SeatFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Passenger");

                    b.Navigation("Seat");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Seat", b =>
                {
                    b.HasOne("AM.ApplicationCore.Domain.Plane", "Plane")
                        .WithMany("Seats")
                        .HasForeignKey("PlaneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AM.ApplicationCore.Domain.Section", "Section")
                        .WithMany("Seats")
                        .HasForeignKey("SectionFk")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Plane");

                    b.Navigation("Section");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Ticket", b =>
                {
                    b.HasOne("AM.ApplicationCore.Domain.Flight", "Flight")
                        .WithMany("Tickets")
                        .HasForeignKey("FlightFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AM.ApplicationCore.Domain.Passenger", "Passenger")
                        .WithMany("Tickets")
                        .HasForeignKey("PassengerFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");

                    b.Navigation("Passenger");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Staff", b =>
                {
                    b.HasOne("AM.ApplicationCore.Domain.Passenger", null)
                        .WithOne()
                        .HasForeignKey("AM.ApplicationCore.Domain.Staff", "PassportNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Traveller", b =>
                {
                    b.HasOne("AM.ApplicationCore.Domain.Passenger", null)
                        .WithOne()
                        .HasForeignKey("AM.ApplicationCore.Domain.Traveller", "PassportNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Flight", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Passenger", b =>
                {
                    b.Navigation("Reservations");

                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Plane", b =>
                {
                    b.Navigation("Flights");

                    b.Navigation("Seats");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Seat", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Section", b =>
                {
                    b.Navigation("Seats");
                });
#pragma warning restore 612, 618
        }
    }
}
