namespace CollectionsAndGenericCollections
{
    //logic of comparison is writtem outside of Employee class: externalization of comparison
    public class EmployeeComparison : IComparer<Employee>
    {
        private int? _sortChoice;
        public EmployeeComparison()
        {

        }
        public EmployeeComparison(int? sortChoice)
        {
            _sortChoice = sortChoice;
        }

        public int Compare(Employee? x, Employee? y)
        {
            //if (x != null && y != null)
            //    if (x.Name != null && y.Name != null)
            //        return x.Name.CompareTo(y.Name);
            //    else
            //        throw new NullReferenceException();
            //else
            //    throw new NullReferenceException();

            if (x != null && y != null)
            {
                int? compRes = null;
                if (_sortChoice.HasValue)
                {
                    switch (_sortChoice.Value)
                    {
                        case 1:
                            compRes = x.Id.CompareTo(y.Id);
                            break;
                        case 2:
                            compRes = x.Name.CompareTo(y.Name);
                            break;
                        case 3:
                            compRes = x.Salary.CompareTo(y.Salary);
                            break;
                        default:
                            compRes = x.Id.CompareTo(y.Id);
                            break;

                    }
                }
                else
                    compRes = x.Id.CompareTo(y.Id);
                return compRes.Value;
            }
            else
                throw new NullReferenceException();
        }
    }
}
