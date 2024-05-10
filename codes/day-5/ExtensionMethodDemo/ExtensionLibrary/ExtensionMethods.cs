using CalculationLibrary;

namespace ExtensionLibrary
{
    public static class ExtensionMethods
    {
        public static int Subtract(this ICalculation calc, int x, int y)
        {
            return x - y;
        }
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> values)
        {
            return new List<T>();
        }
    }
}
