using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.DotNet.Scaffolding.Shared.Project;
using Microsoft.EntityFrameworkCore;
using MyFirstStack.Models;

namespace MyFirstStack.Data
{
    public class MyFirstStackDb : DbContext
    {
        public MyFirstStackDb (DbContextOptions<MyFirstStackDb> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
            {
                modelBuilder.Entity<Car>().HasData(
                    new Car
                    {
                        Id = 1,
                        VIN = "123456",
                        Make = "Honda",
                        Model = "Accord",
                        Year = new DateTime(),
                        Color = "Black",
                        Description = "Just a little black honda accord"
                    },
                    new Car
                    {
                        Id = 2,
                        VIN = "223456",
                        Make = "Accura",
                        Model = "Legend",
                        Year = new DateTime(),
                        Color = "Black",
                        Description = "A Nice Luxury Car"
                    },
                    new Car
                    {
                        Id = 3,
                        VIN = "999555444",
                        Make = "Ford",
                        Model = "F150",
                        Year = new DateTime(),
                        Color = "Red",
                        Description = "A Pickup"
                    }
                );

                modelBuilder.Entity<PhoneNumber>().HasData(
                    new PhoneNumber
                    {
                        Id = 1,
                        Phone = "5551212",
                        Type = "Cell"
                    }
                );

                modelBuilder.Entity<People>(p =>
                {
                    p.HasData(
                        new People
                        {
                            Id = 1,
                            FirstName = "Jesse",
                            LastName = "Harlan",
                            BirthDate = new DateTime(),
                        },
                        new People
                        {
                            Id = 2,
                            FirstName = "John",
                            LastName = "Scott",
                            BirthDate = new DateTime(),
                        }
                    );
                });

                modelBuilder.Entity<PeoplePhone>().HasData(
                    // add some people phones based on our normal stuff
                    new PeoplePhone
                    {
                        Id = 1,
                        PeopleId = 1,
                        PhoneNumberId = 1,
                    }
                );

            } else
            {
                // do production stuff here
            }
            

            modelBuilder.Entity<People>().Navigation(e => e.PeopleAddresses).AutoInclude();
            modelBuilder.Entity<People>().Navigation(e => e.PeoplePhones).AutoInclude();
            modelBuilder.Entity<PeoplePhone>().Navigation(e => e.PhoneNumber).AutoInclude();
            modelBuilder.Entity<PeopleAddresses>().Navigation(e => e.Address).AutoInclude();
            
            modelBuilder.Entity<Dealer>().Navigation(e => e.DealerAddresses).AutoInclude();
            modelBuilder.Entity<DealerAddresses>().Navigation(e => e.Address).AutoInclude();

        }

        public DbSet<Car> Car { get; set; }
        public DbSet<People> People { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<PeopleAddresses> PeopleAddress { get; set; }
        public DbSet<DealerAddresses> DealerAddress { get; set; }
    }
}
