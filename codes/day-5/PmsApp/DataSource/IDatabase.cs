using Entities;

namespace DataSource
{
    public interface IDatabase<T> where T : class
    {
        ICollection<T> Products { get; }
    }
}