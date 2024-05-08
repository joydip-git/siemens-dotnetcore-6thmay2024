namespace ObjectClassMethods
{
    public class Employee //:Object
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Salary { get; set; }

        public Employee()
        {

        }

        public Employee(int id, string? name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;

            if (this == obj)
                //if (ReferenceEquals(this, obj))
                return true;

            Employee employee = (Employee)obj;
            if (this.Id != employee.Id)
                return false;

            if (!this.Name.Equals(employee.Name))
                return false;

            if (!this.Salary.Equals(employee.Salary))
                return false;

            return true;
        }

        public override string? ToString()
        {
            //Type type = typeof(Employee);
            Type type = this.GetType();
            //return type?.FullName;
            //if (type == null)
            //    return null;
            //return type.Name;

            return $"{Id}, {Name}, {Salary}";
        }
    }
}
