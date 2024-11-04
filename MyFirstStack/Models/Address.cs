﻿namespace MyFirstStack.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public int DealerId { get; set; }
        public Dealer Dealer { get; set; }
    }
}
