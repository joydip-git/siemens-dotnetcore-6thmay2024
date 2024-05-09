namespace Entities
{
    public class Product //:object
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }

        public Product()
        {

        }

        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString() => $"{Id}, {Name}, {Price}";
    }
}
