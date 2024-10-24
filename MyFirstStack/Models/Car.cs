using System.ComponentModel.DataAnnotations;

namespace MyFirstStack.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
    }
}
