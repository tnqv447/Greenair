﻿// <auto-generated />
using System;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Presentation.Migrations
{
    [DbContext(typeof(GreenairContext))]
    [Migration("20191120182725_Initials")]
    partial class Initials
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("ApplicationCore.Entities.Account", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Username");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Airport", b =>
                {
                    b.Property<string>("AirportId")
                        .HasColumnType("TEXT");

                    b.Property<string>("AirportName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AirportId");

                    b.ToTable("Airports");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Flight", b =>
                {
                    b.Property<string>("FlightId")
                        .HasColumnType("TEXT");

                    b.Property<string>("PlaneId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("FlightId");

                    b.HasIndex("PlaneId");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("ApplicationCore.Entities.FlightDetail", b =>
                {
                    b.Property<string>("FlightDetailId")
                        .HasColumnType("TEXT");

                    b.Property<string>("FlightId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ArrDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DepDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("RouteId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("FlightDetailId", "FlightId");

                    b.HasIndex("FlightId");

                    b.HasIndex("RouteId");

                    b.ToTable("FlightDetails");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Job", b =>
                {
                    b.Property<string>("JobId")
                        .HasColumnType("TEXT")
                        .HasMaxLength(3);

                    b.Property<string>("JobName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.HasKey("JobId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Maker", b =>
                {
                    b.Property<string>("MakerId")
                        .HasColumnType("TEXT")
                        .HasMaxLength(3);

                    b.Property<string>("MakerName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.HasKey("MakerId");

                    b.ToTable("Makers");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Person", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT")
                        .HasMaxLength(5);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(10);

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Plane", b =>
                {
                    b.Property<string>("PlaneId")
                        .HasColumnType("TEXT")
                        .HasMaxLength(5);

                    b.Property<string>("MakerId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SeatNum")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlaneId");

                    b.HasIndex("MakerId");

                    b.ToTable("Planes");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Route", b =>
                {
                    b.Property<string>("RouteId")
                        .HasColumnType("TEXT")
                        .HasMaxLength(5);

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RouteId");

                    b.HasIndex("Destination");

                    b.HasIndex("Origin", "Destination")
                        .IsUnique();

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Ticket", b =>
                {
                    b.Property<string>("TicketId")
                        .HasColumnType("TEXT")
                        .HasMaxLength(5);

                    b.Property<string>("FlightId")
                        .HasColumnType("TEXT");

                    b.Property<string>("AssignedCus")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TicketTypeId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TicketId", "FlightId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("FlightId");

                    b.HasIndex("TicketTypeId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("ApplicationCore.Entities.TicketType", b =>
                {
                    b.Property<string>("TicketTypeId")
                        .HasColumnType("TEXT")
                        .HasMaxLength(3);

                    b.Property<decimal>("BasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TicketTypeName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.HasKey("TicketTypeId");

                    b.ToTable("TicketTypes");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Customer", b =>
                {
                    b.HasBaseType("ApplicationCore.Entities.Person");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Customer");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Employer", b =>
                {
                    b.HasBaseType("ApplicationCore.Entities.Person");

                    b.Property<string>("JobId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasIndex("JobId");

                    b.HasDiscriminator().HasValue("Employer");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Account", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Person", "Person")
                        .WithOne("Account")
                        .HasForeignKey("ApplicationCore.Entities.Account", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationCore.Entities.Airport", b =>
                {
                    b.OwnsOne("ApplicationCore.Entities.Address", "Address", b1 =>
                        {
                            b1.Property<string>("AirportId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("City")
                                .HasColumnName("City")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Country")
                                .HasColumnName("Country")
                                .HasColumnType("TEXT");

                            b1.Property<string>("District")
                                .HasColumnName("District")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Num")
                                .HasColumnName("AddressNum")
                                .HasColumnType("TEXT");

                            b1.Property<string>("State")
                                .HasColumnName("State")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Street")
                                .HasColumnName("Street")
                                .HasColumnType("TEXT");

                            b1.HasKey("AirportId");

                            b1.ToTable("Airports");

                            b1.WithOwner()
                                .HasForeignKey("AirportId");
                        });
                });

            modelBuilder.Entity("ApplicationCore.Entities.Flight", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Plane", "Plane")
                        .WithMany("Flights")
                        .HasForeignKey("PlaneId");
                });

            modelBuilder.Entity("ApplicationCore.Entities.FlightDetail", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Flight", "Flight")
                        .WithMany("FlightDetails")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Entities.Route", "Route")
                        .WithMany("FlightDetails")
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationCore.Entities.Maker", b =>
                {
                    b.OwnsOne("ApplicationCore.Entities.Address", "Address", b1 =>
                        {
                            b1.Property<string>("MakerId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("City")
                                .HasColumnName("City")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Country")
                                .HasColumnName("Country")
                                .HasColumnType("TEXT");

                            b1.Property<string>("District")
                                .HasColumnName("District")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Num")
                                .HasColumnName("AddressNum")
                                .HasColumnType("TEXT");

                            b1.Property<string>("State")
                                .HasColumnName("State")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Street")
                                .HasColumnName("Street")
                                .HasColumnType("TEXT");

                            b1.HasKey("MakerId");

                            b1.ToTable("Makers");

                            b1.WithOwner()
                                .HasForeignKey("MakerId");
                        });
                });

            modelBuilder.Entity("ApplicationCore.Entities.Person", b =>
                {
                    b.OwnsOne("ApplicationCore.Entities.Address", "Address", b1 =>
                        {
                            b1.Property<string>("PersonId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("City")
                                .HasColumnName("City")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Country")
                                .HasColumnName("Country")
                                .HasColumnType("TEXT");

                            b1.Property<string>("District")
                                .HasColumnName("District")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Num")
                                .HasColumnName("AddressNum")
                                .HasColumnType("TEXT");

                            b1.Property<string>("State")
                                .HasColumnName("State")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Street")
                                .HasColumnName("Street")
                                .HasColumnType("TEXT");

                            b1.HasKey("PersonId");

                            b1.ToTable("Persons");

                            b1.WithOwner()
                                .HasForeignKey("PersonId");
                        });
                });

            modelBuilder.Entity("ApplicationCore.Entities.Plane", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Maker", "Maker")
                        .WithMany("Planes")
                        .HasForeignKey("MakerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationCore.Entities.Route", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Airport", "DesAirport")
                        .WithMany("RouteEnds")
                        .HasForeignKey("Destination")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Entities.Airport", "OrgAirport")
                        .WithMany("RouteStarts")
                        .HasForeignKey("Origin")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("ApplicationCore.Entities.FlightTime", "FlightTime", b1 =>
                        {
                            b1.Property<string>("RouteId")
                                .HasColumnType("TEXT");

                            b1.Property<int>("Hour")
                                .HasColumnName("FlightHour")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("Minute")
                                .HasColumnName("FlightMinute")
                                .HasColumnType("INTEGER");

                            b1.HasKey("RouteId");

                            b1.ToTable("Routes");

                            b1.WithOwner()
                                .HasForeignKey("RouteId");
                        });
                });

            modelBuilder.Entity("ApplicationCore.Entities.Ticket", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Customer", "Customer")
                        .WithMany("Tickets")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Entities.Flight", "Flight")
                        .WithMany("Tickets")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Entities.TicketType", "TicketType")
                        .WithMany("Tickets")
                        .HasForeignKey("TicketTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationCore.Entities.Employer", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Job", "Job")
                        .WithMany("Employers")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
