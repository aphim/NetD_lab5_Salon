﻿//Program:      Netd 3202 Lab 5 Salon Webpage
//Created by:   Jacky Yuan
//Date:         Dec 04, 2020
//Purpose:      Basic website for a hair salon
//Change log:   N/A
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetD_lab5_Salon.Models;

namespace NetD_lab5_Salon.Migrations
{
    [DbContext(typeof(Saloncontext))]
    partial class SaloncontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("NetD_lab5_Salon.Models.Stylist", b =>
                {
                    b.Property<int>("stylistID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("stylistExt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("stylistFName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("stylistLName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("stylistID");

                    b.ToTable("stylist");
                });

            modelBuilder.Entity("NetD_lab5_Salon.Models.appointment", b =>
                {
                    b.Property<int>("appointmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("appointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("clientID")
                        .HasColumnType("int");

                    b.Property<int>("stylistID")
                        .HasColumnType("int");

                    b.HasKey("appointmentID");

                    b.HasIndex("clientID");

                    b.HasIndex("stylistID");

                    b.ToTable("appointment");
                });

            modelBuilder.Entity("NetD_lab5_Salon.Models.client", b =>
                {
                    b.Property<int>("clientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("clientEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("clientFName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("clientLName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("clientPhonenumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("clientID");

                    b.ToTable("client");
                });

            modelBuilder.Entity("NetD_lab5_Salon.Models.appointment", b =>
                {
                    b.HasOne("NetD_lab5_Salon.Models.client", "client")
                        .WithMany()
                        .HasForeignKey("clientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NetD_lab5_Salon.Models.Stylist", "stylist")
                        .WithMany()
                        .HasForeignKey("stylistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("client");

                    b.Navigation("stylist");
                });
#pragma warning restore 612, 618
        }
    }
}
