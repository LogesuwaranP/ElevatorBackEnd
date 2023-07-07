﻿// <auto-generated />
using System;
using ElevatorTransaction.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ElevatorTransaction.Migrations
{
    [DbContext(typeof(TransactionDbContext))]
    [Migration("20230706101210_timeOnlyTicksOnly")]
    partial class timeOnlyTicksOnly
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ElevatorTransaction.Models.LiftConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BatteryCapacity")
                        .HasColumnType("int");

                    b.Property<int>("BatteryLevel")
                        .HasColumnType("int");

                    b.Property<string>("BatteryType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoorOpenCloseSpeed")
                        .HasColumnType("int");

                    b.Property<string>("LiftBrand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LiftCapacity")
                        .HasColumnType("int");

                    b.Property<int>("LiftMaxSpeed")
                        .HasColumnType("int");

                    b.Property<int>("MaxWeight")
                        .HasColumnType("int");

                    b.Property<int>("PowerConsumed")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LiftConfiguration");
                });

            modelBuilder.Entity("ElevatorTransaction.Models.Transaction", b =>
                {
                    b.Property<int>("CurrentFloor")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOnlyValue")
                        .HasColumnType("datetime2");

                    b.Property<int>("DestinationFloor")
                        .HasColumnType("int");

                    b.Property<int>("PersonCount")
                        .HasColumnType("int");

                    b.Property<double>("PersonWeight")
                        .HasColumnType("float");

                    b.Property<TimeSpan>("TimeOnlyValue")
                        .HasColumnType("time");

                    b.Property<string>("TransactionDateOnly")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionTimeOnly")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
