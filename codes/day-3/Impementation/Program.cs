//var list = GetData();
using System.Collections;

//var emp = new Employee();
//emp["name"] = "Anil";
//emp["id"] = 1;
//Console.WriteLine(emp[0]);
//Console.WriteLine(emp[1]);

MyList<int> list = new MyList<int>();
list.Add(1);
list.Add(2);
list.Add(3);
//for (int i = 0; i < list.Count; i++)
//{
//    Console.WriteLine(list[i]);
//}
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}

IEnumerator<int> cursor = list.GetEnumerator();
//GetEnumerator returns an object of a class (Enumerator) which implements IEnumerator<T> interface
while (cursor.MoveNext())
{
    Console.WriteLine(cursor.Current);
}

static IReadOnlyList<int> GetData()
{
    return new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
}

class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public object this[string key]
    {
        set
        {
            if (key == "name")
            {
                Name = (string)value;
            }
            if (key == "id")
            {
                Id = (int)value;
            }
        }
        get
        {
            if (key == "name")
            {
                return Name ??= "";
            }
            if (key == "id")
            {
                return Id;
            }
            return "no value for this key";
        }
    }
    public object this[int key]
    {
        set
        {
            if (key == 0)
            {
                Name = (string)value;
            }
            if (key == 1)
            {
                Id = (int)value;
            }
        }
        get
        {
            if (key == 0)
            {
                return Name ??= "";
            }
            if (key == 1)
            {
                return Id;
            }
            return "no value for this key";
        }
    }
}

class MyList<T> : IEnumerable<T>
{
    T[] elements;
    static int index = 0;

    public MyList()
    {
        elements = new T[4];
    }
    public void Add(T obj)
    {
        if (index == elements.Length)
        {
            T[] copy = new T[elements.Length];
            elements.CopyTo(copy, 0);
            elements = new T[copy.Length * 2];
            copy.CopyTo(elements, 0);
        }
        elements[index] = obj;
        index++;
    }

    public int Count => index;

    public T this[int index]
    {
        get { return elements[index]; }
        set { elements[index] = value; }
    }

    public IEnumerator<T> GetEnumerator()
    {       
        for (int i = 0; i < this.Count; i++)
        {
            yield return elements[i];
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        for (int i = 0; i < this.Count; i++)
        {
            yield return elements[i];
        }
    }
}
