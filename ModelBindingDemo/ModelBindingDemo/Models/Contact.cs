namespace ModelBindingDemo.Models
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        
    }

    public interface IContact
    {
        string FirstName { get; set; }
    }
    public class Contact: IContact
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Address Shipping{ get; set; }
        public Address Billing{ get; set; }


    }

    public class Bagel
    {
        public string Name { get; set; }
        public string Option { get; set; }
        
    }
}