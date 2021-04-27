namespace Loja.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public Category Category { get; set; }
    }
}