using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace MyFirstStack.Models
{
    public class People
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<PeoplePhone> PeoplePhones { get; set; }
    }

    public class PeoplePhone
    {
        public int Id { get; set; }
        public int PeopleId { get; set; }
        public int PhoneNumberId { get; set; }
        public People People { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
    }

    public class PhoneNumber
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Type { get; set; }
        public ICollection<PeoplePhone> peoplePhones { get; set; }
    }
}
