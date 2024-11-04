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

        public DbSet<Car> Car { get; set; } = default!;
        public DbSet<People> People { get; set; } = default!;
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
    }
}
