using System.Collections;

namespace CollectionsAndGenericCollections
{
    public class CollectionTypes
    {
        public static void UseArrayList()
        {
            ArrayList al = new ArrayList();

            al.Add(12); //0
            al.Add('a'); //1
            al.Add("siemens"); //2
            al.Add(12.34M); //3
            al.Add(12.43F); //4
            al.Add(12.56D); //5
            al.Insert(1, 'x'); //index<=6
            al.Add(13);
            al.Add(11);
            al.Add(12);

            //al.Remove(12);
            //al.RemoveAt(3);

            //al.Contains(12);
            //al.IndexOf(12);
            Console.WriteLine(al.Count);
            Console.WriteLine(al.Capacity);

            for (int j = 0; j < al.Count; j++)
            {
                Console.WriteLine(al[j]);
            }
            foreach (object item in al)
            {
                Console.WriteLine(item);
            }
            //IEnumerable
            IEnumerator ie = al.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Current);
            }
        }

        public static void UseList()
        {
            List<int> list = new List<int>();
            list.Add(12); //0
            list.Add(1); //1
            list.Add(13); //2
            list.Add(12); //3
            list.Add('a'); //4 [count=5, capacity=8]
                           // list[5] = 21;
                           //insertion
            list.Insert(5, 21); //<=5
                                //use indexer for updation
            list[5] = 30;
            //list[6] = 21;
            list.Add(12);

            Console.WriteLine("removing 12s");
            for (int index = 0; index < list.Count; index++)
            {
                if (list[index] == 12)
                {
                    list.RemoveAt(index);
                }
            }
            Console.WriteLine("printing values");
            for (int j = 0; j < list.Count; j++)
            {
                Console.WriteLine(list[j]);
            }
            /*
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            //IEnumerable<T>
            IEnumerator<int> ie = list.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Current);
            }
            */
        }

        public static void SortIntegerElements()
        {
            //collection initializer
            var numbers = new List<int>
            {
               3,1,5,2,8,4,6,0,9,7
            };

            //numbers.Sort();
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        var temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        public static void SortEmployess()
        {
            var employees = new List<Employee>
            {
                new Employee { Id=2, Name="anil", Salary=3000},
                new() { Id=1, Name="sunil", Salary=2000},
                new() { Id=3, Name="joydip", Salary=1000},
            };

            //sorting
            //for (int i = 0; i < employees.Count; i++)
            //{
            //    for (int j = i + 1; j < employees.Count; j++)
            //    {
            //        if (employees[i] > employees[j])
            //        {
            //            var temp = employees[i];
            //            employees[i] = employees[j];
            //            employees[j] = temp;
            //        }
            //    }
            //}

            //1. Employee class must implement IComparable<T> interface and its method CompareTo()
            // employees.Sort();
            //for (int i = 0; i < employees.Count; i++)
            //{
            //    for (int j = i + 1; j < employees.Count; j++)
            //    {
            //        if (employees[i].CompareTo(employees[j])>0)
            //        {
            //            var temp = employees[i];
            //            employees[i] = employees[j];
            //            employees[j] = temp;
            //        }
            //    }
            //}

            Console.WriteLine("1. sort by id\n2. sort by name\n3. sort by salary");
            int choice = int.Parse(Console.ReadLine() ?? "");
            //2. EmployeeComparsion must implement Compare() method from IComparer<T> interface
            var empComp = new EmployeeComparison(sortChoice: choice);
            employees.Sort(empComp);
            //for (int i = 0; i < employees.Count; i++)
            //{
            //    for (int j = i + 1; j < employees.Count; j++)
            //    {
            //        if (empComp.Compare(emplyees[i],employees[j])>0)
            //        {
            //            var temp = employees[i];
            //            employees[i] = employees[j];
            //            employees[j] = temp;
            //        }
            //    }
            //}
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
        }
    }
}
