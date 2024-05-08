namespace CollectionsAndGenericCollections
{
    public class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Salary { get; set; }

        public static bool operator >(Employee a, Employee b)
        {
            return a.Name.CompareTo(b.Name) > 0;
        }
        public static bool operator <(Employee a, Employee b)
        {
            return a.Name.CompareTo(b.Name) < 0;
        }

        public static bool operator >=(Employee a, Employee b)
        {
            return false;
        }
        public static bool operator <=(Employee a, Employee b)
        {
            return false;
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary}";
        }

        //logic of comparison is written inside Employee class: internalization of comparison
        public int CompareTo(Employee? other)
        {
            if (other == null)
                throw new NullReferenceException($"{nameof(other)} is NULL");

            if (other == this) return 0;
            if (this.Name != null && other.Name != null)
                return this.Name.CompareTo(other.Name);
            else
                throw new NullReferenceException("name is null");
        }
    }
}
