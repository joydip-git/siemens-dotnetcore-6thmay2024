using Entities;

Developer anilDev = new Developer(1) { Name = "Anil", BasicPayment = 1000, DaPayment = 1000, HraPayment = 1000 };

//Developer anilDev = new Developer(1, "anil", 1000, 1000, 1000, 1000);
Hr sunilHr = new Hr(2, "sunil", 2000, 2000, 2000, 2000);

Employee[] employees = { anilDev, sunilHr };

foreach (Employee employee in employees)
{
    employee.CalculateSalary();
    Console.WriteLine(employee.TotalPayment);
}

Addition addition = new Addition();
addition.Add(12, 13, 14);

class Addition
{
    public void Add(int x, int y)
    {
        Console.WriteLine(x + y);
    }
    public void Add(int x, int y, int z)
    {
        Console.WriteLine(x + y + z);
    }
    public void Add(int x, int y, long z)
    {
        Console.WriteLine(x + y + z);
    }
    public void Add(int x, long y, int z)
    {
        Console.WriteLine(x + y + z);
    }
}


