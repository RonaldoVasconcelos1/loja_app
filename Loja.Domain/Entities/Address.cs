namespace src.Loja.Domain.Entities
{
    public class Address
    {
        public string Zipcode { get; set; }
        public string Street { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public int Number { get; set; }
        public string complement { get; set; }
    }
}