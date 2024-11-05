﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyFirstStack.Data;

#nullable disable

namespace MyFirstStack.Migrations
{
    [DbContext(typeof(MyFirstStackDb))]
    [Migration("20241105185003_AddingMissingStuff")]
    partial class AddingMissingStuff
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyFirstStack.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("MyFirstStack.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Year")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("MyFirstStack.Models.Dealer", b =>
                {
                    b.Property<int>("DealerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DealerId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DealerId");

                    b.ToTable("Dealers");
                });

            modelBuilder.Entity("MyFirstStack.Models.DealerAddresses", b =>
                {
                    b.Property<int>("DealerAddressesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DealerAddressesId"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("DealerId")
                        .HasColumnType("int");

                    b.HasKey("DealerAddressesId");

                    b.HasIndex("DealerId");

                    b.ToTable("DealerAddress");
                });

            modelBuilder.Entity("MyFirstStack.Models.People", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("MyFirstStack.Models.PeopleAddresses", b =>
                {
                    b.Property<int>("PeopleAddressesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PeopleAddressesId"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("PeopleId")
                        .HasColumnType("int");

                    b.HasKey("PeopleAddressesId");

                    b.HasIndex("PeopleId");

                    b.ToTable("PeopleAddress");
                });

            modelBuilder.Entity("MyFirstStack.Models.PeoplePhone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PeopleId")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumberId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PeopleId");

                    b.HasIndex("PhoneNumberId");

                    b.ToTable("PeoplePhone");
                });

            modelBuilder.Entity("MyFirstStack.Models.PhoneNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PhoneNumbers");
                });

            modelBuilder.Entity("MyFirstStack.Models.DealerAddresses", b =>
                {
                    b.HasOne("MyFirstStack.Models.Dealer", null)
                        .WithMany("DealerAddresses")
                        .HasForeignKey("DealerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyFirstStack.Models.PeopleAddresses", b =>
                {
                    b.HasOne("MyFirstStack.Models.People", null)
                        .WithMany("PeopleAddresses")
                        .HasForeignKey("PeopleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyFirstStack.Models.PeoplePhone", b =>
                {
                    b.HasOne("MyFirstStack.Models.People", null)
                        .WithMany("PeoplePhones")
                        .HasForeignKey("PeopleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyFirstStack.Models.PhoneNumber", "PhoneNumber")
                        .WithMany()
                        .HasForeignKey("PhoneNumberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PhoneNumber");
                });

            modelBuilder.Entity("MyFirstStack.Models.Dealer", b =>
                {
                    b.Navigation("DealerAddresses");
                });

            modelBuilder.Entity("MyFirstStack.Models.People", b =>
                {
                    b.Navigation("PeopleAddresses");

                    b.Navigation("PeoplePhones");
                });
#pragma warning restore 612, 618
        }
    }
}