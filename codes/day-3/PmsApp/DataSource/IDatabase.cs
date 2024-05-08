using Entities;

namespace DataSource
{
    public interface IDatabase
    {
        ICollection<Product> Products { get; }
    }
}