﻿// <auto-generated />
using CodingClubTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodingClubTest.Migrations
{
    [DbContext(typeof(CodingClubDbContext))]
    [Migration("20181008210920_Clients")]
    partial class Clients
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065");

            modelBuilder.Entity("CodingClubTest.Models.Client", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("Job")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("CodingClubTest.Models.Member", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Classification")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("buffID")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("ID");

                    b.ToTable("Member");
                });
#pragma warning restore 612, 618
        }
    }
}
