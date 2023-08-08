namespace kütüphaneler.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public DateTime? Age { get; set; }

        public IList<Address> Addresss { get; set; }
    }
}
