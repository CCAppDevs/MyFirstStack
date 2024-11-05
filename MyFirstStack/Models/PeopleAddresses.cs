namespace MyFirstStack.Models
{
    public class PeopleAddresses
    {
        public int PeopleAddressesId { get; set; }
        public int PeopleId { get; set; }
        public int AddressId { get; set; }

        // navigation properties
        public Address Address { get; set; }
    }
}
