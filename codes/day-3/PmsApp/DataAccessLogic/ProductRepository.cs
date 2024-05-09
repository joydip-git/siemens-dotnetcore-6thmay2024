using DataSource;
using Entities;
using PmsAppExceptions;

namespace DataAccessLogic
{
    //primary constructor feature
    public class ProductRepository(IDatabase<Product> database) : IReposiroty<Product, int>
    {
        private readonly IDatabase<Product> _database = database;

        //public ProductRepository(IDatabase<Product> database)
        //{
        //    _database = database;
        //}

        public bool Add(Product item)
        {
            try
            {
                var records = _database.Products;
                Product? found = DoesExist(item.Id);
                if (found == null)
                    records.Add(item);
                //records.Add(item);
                return found == null;
            }
            catch (NullReferenceException ex)
            {
                var e = ExceptionWrapper<RepositoryException>.WrapException(ex.Message, ex);
                throw e ?? new RepositoryException(ex.Message, ex);
            }
            catch (ArgumentException ex)
            {
                var e = ExceptionWrapper<RepositoryException>.WrapException(ex.Message, ex);
                throw e ?? new RepositoryException(ex.Message, ex);
            }
            catch (Exception ex)
            {
                var e = ExceptionWrapper<RepositoryException>.WrapException(ex.Message, ex);
                throw e ?? new RepositoryException(ex.Message, ex);
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var records = _database.Products;
                Product? found = DoesExist(id);
                if (found != null)
                {
                    records.Remove(found);
                }
                return found != null;
            }
            catch (Exception ex)
            {
                var e = ExceptionWrapper<RepositoryException>.WrapException(ex.Message, ex);
                throw e ?? new RepositoryException(ex.Message, ex);
            }
        }

        public Product? Get(int id)
        {
            try
            {
                Product? found = DoesExist(id);
                return found;
            }
            catch (Exception ex)
            {
                var e = ExceptionWrapper<RepositoryException>.WrapException(ex.Message, ex);
                throw e ?? new RepositoryException(ex.Message, ex);
            }
        }

        public IEnumerable<Product> GetAll()
        {
            return _database.Products;
        }

        public bool Update(int id, Product item)
        {
            try
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
            catch (Exception ex)
            {
                var e = ExceptionWrapper<RepositoryException>.WrapException(ex.Message, ex);
                throw e ?? new RepositoryException(ex.Message, ex);
            }
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
