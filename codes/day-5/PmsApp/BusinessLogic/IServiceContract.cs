namespace BusinessLogic
{
    public interface IServiceContract<T, TId> where T : class
    {
        T? Fetch(int id);
        IEnumerable<T>? FetchAll(int sortChoice = 0);       
        bool Insert(T item);
        bool Modify(TId id, T item);
        bool Remove(TId id);
    }
}
