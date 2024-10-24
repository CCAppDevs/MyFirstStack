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

        public DbSet<MyFirstStack.Models.Car> Car { get; set; } = default!;
        public DbSet<MyFirstStack.Models.People> People { get; set; } = default!;
    }
}
