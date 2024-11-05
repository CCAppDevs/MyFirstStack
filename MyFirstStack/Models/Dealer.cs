namespace MyFirstStack.Models
{
    public class Dealer
    {
        public int DealerId { get; set; }
        public string Name { get; set; }

        // helper - Navigation property
        public ICollection<DealerAddresses> DealerAddresses { get; set; }
    }
}
