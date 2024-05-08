namespace Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal Price { get; set; }

        public Product()
        {

        }

        public Product(int id, string name, string description, decimal price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj == this) return true;
            Product other = obj as Product;
            if (!this.Id.Equals(other.Id))
                return false;
            return true;
        }

        public override int GetHashCode()
        {
            const int prime = 31;
            return this.Id.GetHashCode() * prime;
        }

        public override string? ToString() => $"{Id}, {Name}, {Price}, {Description}";
    }
}
