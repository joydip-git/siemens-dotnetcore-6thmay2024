using Entities;

namespace DataSource
{
    public class Database : IDatabase<Product>
    {
        private static ICollection<Product> products;
        /*
        static Database()
        {
            products = new HashSet<Product>
            {
                new(){Id=3, Name="Dell XPS", Description="New laptop from dell", Price=120000},
                 new(){Id=1, Name="HP Probook", Description="New laptop from hp", Price=130000},
                  new(){Id=2, Name="Lenovo Thinkpad", Description="New laptop from lenovo", Price=100000}
            };
        }*/

        public ICollection<Product> Products => products;
    }
}
