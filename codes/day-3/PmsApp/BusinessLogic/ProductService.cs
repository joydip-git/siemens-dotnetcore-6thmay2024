using DataAccessLogic;
using Entities;

namespace BusinessLogic
{
    public class ProductService(IReposiroty<Product, int> reposiroty) : IServiceContract<Product, int>
    {
        private readonly IReposiroty<Product, int> _reposiroty = reposiroty;

        public Product? Fetch(int id)
        {
            if (id > 0)
            {
                return _reposiroty.Get(id);
            }
            return null;
        }

        public IEnumerable<Product> FetchAll(int sortChoice = 0)
        {
            var records = _reposiroty.GetAll();
            if (records == null)
                throw new Exception("could not fetch records");
            else if (records?.Count() == 0)
                throw new Exception("no records");
            else
                return records;
        }

        public bool Insert(Product item)
        {
            if (item == null)
                throw new NullReferenceException("argument was null");
            var records = _reposiroty.GetAll();
            if (records == null)
                throw new Exception("could not fetch records");
            else if (records?.Count() == 0)
                throw new Exception("no records");
            else
            {
                //auto generation of id for an item
                Random rand = new Random();
                item.Id = rand.Next(100, 200);
                return _reposiroty.Add(item);
            }
        }

        public bool Modify(int id, Product item)
        {
            if (id > 0)
            {
                if (item == null)
                    throw new NullReferenceException("argument was null");

                return _reposiroty.Update(id, item);
            }
            return false;
        }

        public bool Remove(int id)
        {
            if (id > 0)
            {
                return _reposiroty.Delete(id);
            }
            return false;
        }
    }
}
