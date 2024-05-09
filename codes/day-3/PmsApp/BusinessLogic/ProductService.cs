using DataAccessLogic;
using Entities;
using PmsAppExceptions;

namespace BusinessLogic
{
    public class ProductService(IReposiroty<Product, int> reposiroty) : IServiceContract<Product, int>
    {
        private readonly IReposiroty<Product, int> _reposiroty = reposiroty;

        public Product? Fetch(int id)
        {
            try
            {
                if (id > 0)
                {
                    return _reposiroty.Get(id);
                }
                return null;
            }
            catch (RepositoryException ex)
            {
                var e = ExceptionWrapper<ServiceException>.WrapException(ex.Message, ex);
                throw e ?? new ServiceException(ex.Message, ex);
            }
            catch (Exception ex)
            {
                var e = ExceptionWrapper<ServiceException>.WrapException(ex.Message, ex);
                throw e ?? new ServiceException(ex.Message, ex);
            }
        }

        public IEnumerable<Product>? FetchAll(int sortChoice = 0)
        {
            try
            {
                var records = _reposiroty.GetAll();
                if (records == null)
                    throw new NullReferenceException("could not fetch records");
                else if (records?.Count() == 0)
                    throw new ServiceException("no records");
                else
                {
                    IEnumerable<Product>? result = null;
                    switch (sortChoice)
                    {
                        case 1:
                            result = records?.OrderBy(p => p.Id);
                            break;
                        case 2:
                            result = records?.OrderBy(p => p.Name);
                            break;
                        case 3:
                            result = records?.OrderBy(p => p.Price);
                            break;
                        default:
                            result = records?.OrderBy(p => p.Id);
                            break;
                    }
                    return result;
                }
            }
            catch (NullReferenceException ex)
            {
                var e = ExceptionWrapper<ServiceException>.WrapException(ex.Message, ex);
                throw e ?? new ServiceException(ex.Message, ex);
            }
            catch (ServiceException)
            {
                throw;
            }
            catch (RepositoryException ex)
            {
                var e = ExceptionWrapper<ServiceException>.WrapException(ex.Message, ex);
                throw e ?? new ServiceException(ex.Message, ex);
            }
            catch (Exception ex)
            {
                var e = ExceptionWrapper<ServiceException>.WrapException(ex.Message, ex);
                throw e ?? new ServiceException(ex.Message, ex);
            }
        }

        public bool Insert(Product item)
        {
            try
            {
                if (item == null)
                    throw new NullReferenceException("argument was null");
                var records = _reposiroty.GetAll();
                if (records == null)
                    throw new NullReferenceException("could not fetch records");
                else if (records?.Count() == 0)
                {
                    item.Id = 1;
                }
                else
                {
                    //auto generation of id for an item
                    //Random rand = new Random();
                    //item.Id = rand.Next(100, 200);
                    var lastProduct = records?.Last();
                    if (lastProduct != null)
                    {
                        item.Id = lastProduct.Id + 1;
                    }                    
                }
                return _reposiroty.Add(item);
            }
            catch (RepositoryException ex)
            {
                var e = ExceptionWrapper<ServiceException>.WrapException(ex.Message, ex);
                throw e ?? new ServiceException(ex.Message, ex);
            }
            catch (NullReferenceException ex)
            {
                var e = ExceptionWrapper<ServiceException>.WrapException(ex.Message, ex);
                throw e ?? new ServiceException(ex.Message, ex);
            }
            catch (ServiceException)
            {
                throw;
            }
            catch (Exception ex)
            {
                var e = ExceptionWrapper<ServiceException>.WrapException(ex.Message, ex);
                throw e ?? new ServiceException(ex.Message, ex);
            }
        }

        public bool Modify(int id, Product item)
        {
            try
            {
                if (id > 0)
                {
                    if (item == null)
                        throw new NullReferenceException("argument was null");

                    return _reposiroty.Update(id, item);
                }
                return false;
            }
            catch (NullReferenceException ex)
            {
                var e = ExceptionWrapper<ServiceException>.WrapException(ex.Message, ex);
                throw e ?? new ServiceException(ex.Message, ex);
            }
            catch (RepositoryException ex)
            {
                var e = ExceptionWrapper<ServiceException>.WrapException(ex.Message, ex);
                throw e ?? new ServiceException(ex.Message, ex);
            }
            catch (Exception ex)
            {
                var e = ExceptionWrapper<ServiceException>.WrapException(ex.Message, ex);
                throw e ?? new ServiceException(ex.Message, ex);
            }
        }

        public bool Remove(int id)
        {
            try
            {
                if (id > 0)
                {
                    return _reposiroty.Delete(id);
                }
                return false;
            }
            catch (RepositoryException ex)
            {
                var e = ExceptionWrapper<ServiceException>.WrapException(ex.Message, ex);
                throw e ?? new ServiceException(ex.Message, ex);
            }
            catch (Exception ex)
            {
                var e = ExceptionWrapper<ServiceException>.WrapException(ex.Message, ex);
                throw e ?? new ServiceException(ex.Message, ex);
            }
        }
    }
}
