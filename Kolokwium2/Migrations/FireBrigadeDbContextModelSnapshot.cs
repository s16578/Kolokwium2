﻿// <auto-generated />
using System;
using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kolokwium2.Migrations
{
    [DbContext(typeof(FireBrigadeDbContext))]
    partial class FireBrigadeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kolokwium2.Models.ActionEntity", b =>
                {
                    b.Property<int>("IdAction")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("NeedSpecialEquipment")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("IdAction");

                    b.ToTable("Actions");
                });

            modelBuilder.Entity("Kolokwium2.Models.FireTruck", b =>
                {
                    b.Property<int>("IdFireTruck")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OperationalNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<bool>("SpecialEquipment")
                        .HasColumnType("bit");

                    b.HasKey("IdFireTruck");

                    b.ToTable("FireTrucks");
                });

            modelBuilder.Entity("Kolokwium2.Models.FireTruckAction", b =>
                {
                    b.Property<int>("IdFireTruckAction")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AssignmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdAction")
                        .HasColumnType("int");

                    b.Property<int>("IdFireTruck")
                        .HasColumnType("int");

                    b.HasKey("IdFireTruckAction");

                    b.HasIndex("IdAction");

                    b.HasIndex("IdFireTruck");

                    b.ToTable("FireTruckActions");
                });

            modelBuilder.Entity("Kolokwium2.Models.Firefighter", b =>
                {
                    b.Property<int>("IdFirefighter")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("IdFirefighter");

                    b.ToTable("Firefighters");
                });

            modelBuilder.Entity("Kolokwium2.Models.FirefighterAction", b =>
                {
                    b.Property<int>("IdAction")
                        .HasColumnType("int");

                    b.Property<int>("IdFirefighter")
                        .HasColumnType("int");

                    b.HasKey("IdAction", "IdFirefighter");

                    b.HasIndex("IdFirefighter");

                    b.ToTable("FirefighterActions");
                });

            modelBuilder.Entity("Kolokwium2.Models.FireTruckAction", b =>
                {
                    b.HasOne("Kolokwium2.Models.ActionEntity", "ActionEntity")
                        .WithMany("FireTruckActions")
                        .HasForeignKey("IdAction")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kolokwium2.Models.FireTruck", "FireTruck")
                        .WithMany("FireTruckActions")
                        .HasForeignKey("IdFireTruck")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Kolokwium2.Models.FirefighterAction", b =>
                {
                    b.HasOne("Kolokwium2.Models.ActionEntity", "ActionEntity")
                        .WithMany("FirefighterActions")
                        .HasForeignKey("IdAction")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kolokwium2.Models.Firefighter", "Firefighter")
                        .WithMany("FirefighterActions")
                        .HasForeignKey("IdFirefighter")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
