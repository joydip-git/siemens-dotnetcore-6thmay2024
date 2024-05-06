namespace SampleNETApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello world");
            int value = 100;
            Console.WriteLine(value);

            Nullable<int> x = null;
            //x = 200;
            Console.WriteLine(x.GetHashCode());

            /*
           if (x.HasValue)
           {
               // Console.WriteLine(x.Value);
               Console.WriteLine(x);
           }
           else
               Console.WriteLine("null");
           */

            int? y = 200;
            Console.WriteLine(y);

            Demo? demo = null;
            demo = new Demo();
            //if (demo != null)
            //{
            string? data = demo?.SplitSentence("asjsa");
            Console.WriteLine(data ?? data);
            //Console.WriteLine(data != null ? data : "NA");
            //}

            int[] numbers = new int[2];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("enter value at numbers[" + i + "]: ");
                int num = int.Parse(Console.ReadLine());
                numbers[i] = num;
            }

            foreach (int intValue in numbers)
            {
                Console.WriteLine(intValue);
            }
        }
    }
}