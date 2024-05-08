namespace ObjectClassMethods
{
    public class EmployeeManager
    {
        public Employee Create(int id, string? name, double salary)
        {
            return new Employee(id, name, salary);
        }
    }
}
