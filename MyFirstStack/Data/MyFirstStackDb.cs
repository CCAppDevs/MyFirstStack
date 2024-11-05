using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public DbSet<Car> Car { get; set; }
        public DbSet<People> People { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<PeopleAddresses> PeopleAddress { get; set; }
        public DbSet<DealerAddresses> DealerAddress { get; set; }
    }
}
