using CalculationLibrary;
using ExtensionLibrary;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICalculation calculation = new Calculation();
            Console.WriteLine(calculation.Add(12, 13));
            Console.WriteLine(calculation.Subtract(12, 3));

            List<int> ints = new List<int>();
            //ints.Filter();
        }
    }
}
