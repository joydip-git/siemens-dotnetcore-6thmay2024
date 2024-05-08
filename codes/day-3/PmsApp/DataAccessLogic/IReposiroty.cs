namespace DataAccessLogic
{
    public interface IReposiroty<T, TId> where T : class
    {
        T? Get(int id);
        IEnumerable<T> GetAll();
        bool Add(T item);
        bool Update(TId id, T item);
        bool Delete(TId id);
    }
}
