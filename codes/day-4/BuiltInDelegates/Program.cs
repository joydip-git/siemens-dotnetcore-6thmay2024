namespace BuiltInDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int> func = () => 10;
            Func<int, int> func1 = (x) => x++;
            Func<int, int, int> func2 = (x, y) => x + y;
            Predicate<int> evenDel = x => x % 2 == 0;
            Func<int, bool> oddDel = x => x % 2 != 0;
            Predicate<string> del = name => name.Contains('a');
            Action<string> print = name => Console.WriteLine(name);

            //LINQ => Language INtegrated Query
            //functional programming:

            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //IEnumerable<int> evenNumbers = numbers.Where(oddDel);
            //IOrderedEnumerable<int> sortedNumbers = evenNumbers.OrderByDescending(x => x);

            //Method (query) syntax
            numbers
                .Where(x => x % 2 != 0)
                .OrderByDescending(x => x)
                .ToList()
                .ForEach(x => Console.WriteLine(x));

            //Query (operator) syntax
            IOrderedEnumerable<int> query = from x in numbers
                                            where x % 2 == 0
                                            orderby x descending
                                            select x;

            query.ToList().ForEach(x => Console.WriteLine(x));

            //select x from numbers where x%2==0 order x by x desc

            string[] people = ["sunil", "anil", "mukesh", "sumit", "ankit", "joydip"];
            //IEnumerable<IGrouping<char, string>> groupQuery =
            //    from name in people
            //    orderby name ascending
            //    group name by name[0];

            IEnumerable<IGrouping<char, string>> groupQuery
                = people
                .OrderBy(name => name)
                .GroupBy(name => name[0]);


            foreach (var g in groupQuery)
            {
                Console.WriteLine($"names starting with {g.Key}");
                Console.WriteLine("-------------------");
                foreach (var name in g)
                    Console.WriteLine(name);

                Console.WriteLine("\n");
            }


            /**
             * names starting with 'a'
             * anil
             * ankit
             * 
             * names starting with 'j'
             * joydip
             * 
             * names starting with 'm'
             * mukesh
             * 
             * names starting with 's'
             * sumit
             * sunil
             */

        }
    }
    /*
    interface IGroup<TKey, TElement>
    {
        TKey Key { get; }
        IEnumerator<TElement> GetEnumerator();
    }
    class Group<TKey, TElement> : IGroup<TKey, TElement>
    {
        IList<TElement> collection;
        static int index = 0;
        public Group()
        {
            collection = [];
        }
        public TKey Key => throw new NotImplementedException();

        public IEnumerator<TElement> GetEnumerator()
        {
            for (int i = 0; i < index; i++)
            {
                yield return collection[i];
            }
        }
    }
    */
}