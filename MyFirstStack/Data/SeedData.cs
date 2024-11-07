using Microsoft.EntityFrameworkCore;
using MyFirstStack.Models;

namespace MyFirstStack.Data
{
    public class SeedData
    {
        public static void EnsurePopulated(MyFirstStackDb context)
        {
            // check if the database is created
            context.Database.EnsureCreated();

            // check if we have data
            var data = context.Car.FirstOrDefault();

            // if no data
            if (data == null)
            {
                Car car = new Car
                {
                    Id = 0,
                    VIN = "123456789",
                    Make = "Honda",
                    Model = "Accord",
                    Year = DateTime.Now,
                    Color = "LimeGreen",
                    Description = "Just a fake car for a fake database"
                };

                context.Car.Add(car);
                context.SaveChanges();
            }

            var people = context.People.FirstOrDefault();
            if (people == null)
            {
                People person = new People
                {
                    Id = 0,
                    FirstName = "Jesse",
                    LastName = "Harlan",
                    BirthDate = DateTime.Now,
                    PeoplePhones = new List<PeoplePhone>()
                    {
                        new PeoplePhone
                        {
                            Id = 0,
                            PhoneNumber = new PhoneNumber { Id = 0, Phone = "5551212", Type = "cell" },
                        },
                        new PeoplePhone
                        {
                            Id = 0,
                            PhoneNumber = new PhoneNumber { Id = 0, Phone = "5551213", Type = "Work" },
                        },

                    }
                };

                context.People.Add(person);
                context.SaveChanges();
            }
        }
    }
}
