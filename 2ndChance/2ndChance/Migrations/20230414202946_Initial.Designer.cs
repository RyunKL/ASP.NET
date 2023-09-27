﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _2ndChance.Models;

#nullable disable

namespace _2ndChance.Migrations
{
    [DbContext(typeof(ContactContext))]
    [Migration("20230414202946_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_2ndChance.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Friend"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Work"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Family"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("_2ndChance.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            CategoryId = 1,
                            Date = new DateTime(2023, 4, 14, 16, 29, 46, 735, DateTimeKind.Local).AddTicks(7579),
                            Email = "C.W@hotmail.com",
                            FirstName = "Charles",
                            LastName = "Woo",
                            Phone = "416-111-2222"
                        },
                        new
                        {
                            ContactId = 2,
                            CategoryId = 2,
                            Date = new DateTime(2023, 4, 14, 16, 29, 46, 735, DateTimeKind.Local).AddTicks(7622),
                            Email = "l.Siu@yahoo.ca",
                            FirstName = "Lauren",
                            LastName = "Siu",
                            Phone = "416-114-3333"
                        });
                });

            modelBuilder.Entity("_2ndChance.Models.Contact", b =>
                {
                    b.HasOne("_2ndChance.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}