namespace Loja.Domain.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string Zipcode { get; set; }
        public string Street { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public int Number { get; set; }
        public string complement { get; set; }
        public Client Client { get; set; }
    }
}