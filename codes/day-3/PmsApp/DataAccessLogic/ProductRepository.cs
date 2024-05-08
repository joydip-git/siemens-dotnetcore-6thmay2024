using DataSource;
using Entities;

namespace DataAccessLogic
{
    //primary constructor feature
    public class ProductRepository(Database database) : IReposiroty<Product, int>
    {
        private readonly Database _database = database;
       
        //public ProductRepository(Database database)
        //{
        //    _database = database;
        //}

        public bool Add(Product item)
        {
            var records = _database.Products;
            Product? found = DoesExist(item.Id);
            if (found == null)
                records.Add(item);
            //records.Add(item);
            return found == null;
        }

        public bool Delete(int id)
        {
            var records = _database.Products;
            Product? found = DoesExist(id);
            if (found != null)
            {
                records.Remove(found);
            }
            return found != null;
        }

        public Product? Get(int id)
        {
            Product? found = DoesExist(id);
            return found;
        }

        public IEnumerable<Product> GetAll()
        {
            return _database.Products;
        }

        public bool Update(int id, Product item)
        {
            Product? found = DoesExist(id);
            if (found != null)
            {
                found.Price = item.Price;
                found.Description = item.Description;
                found.Name = item.Name;
            }

            return found != null;
        }

        #region Helper methods
        private Product? DoesExist(int id)
        {
            var records = _database.Products;
            Product? found = null;
            foreach (var p in records)
            {
                if (id == p.Id)
                {
                    found = p;
                    break;
                }
            }
            return found;
        }
        #endregion
    }
}
