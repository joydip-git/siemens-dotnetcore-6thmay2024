/*
static void Add(object x, object y)
{
    if (x.GetType() != typeof(int) && y.GetType() == typeof(int))
    {
        int a = (int)x;
        int b = (int)y;
        Console.WriteLine(a + b);
    }
    if (x.GetType() != typeof(string) && y.GetType() == typeof(string))
    {
        string a = (string)x;
        string b = (string)y;
        Console.WriteLine(a.Concat(b));
    }
}
*/
//Add<string>("siemens", "Ecity");
Add<Employee>(new Employee(1), new Employee(2));
var manager = new Manager<Employee, int>();

static void Add<T>(T x, T y) where T : class//, new()
{

}
//Add<int>(12, 13);
class Employee
{
    public Employee(int id) { }
}

interface IManager<T, TId> where T : class
{
    bool Add(T data);
    T[] GetAll();
    T Get(TId id);
}
class Manager<T, TId> : IManager<T, TId> where T : class
{
    //private EmployeeContext<T> _context;
    //public Manager(EmployeeContext<T> context)
    //{
    //    _context = context;
    //}
    public virtual bool Add(T data)
    {
      //return _context.Add(data);
      return false;
    }

    public virtual T Get(TId id)
    {
        throw new NotImplementedException();
    }

    public virtual T[] GetAll()
    {
        throw new NotImplementedException();
    }

    public virtual T[]? SerachByName(string name)
    {
        return null;
    }
}
class EmployeeManager : Manager<Employee, int>
{
    public override bool Add(Employee data)
    {
        return base.Add(data);
    }

    public override Employee Get(int id)
    {
        return base.Get(id);
    }

    public override Employee[] GetAll()
    {
        return base.GetAll();
    }
    public override Employee[]? SerachByName(string name)
    {
        return base.SerachByName(name);
    }
}


