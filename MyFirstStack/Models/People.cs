using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MyFirstStack.Models
{
    public class People
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public ICollection<PeoplePhone> PeoplePhones { get; set; }
        public ICollection<PeopleAddresses> PeopleAddresses { get; set; }
    }

    public class PeoplePhone
    {
        public int Id { get; set; }
        public int PeopleId { get; set; }
        public int PhoneNumberId { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
    }

    public class PhoneNumber
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Type { get; set; }
    }
}
