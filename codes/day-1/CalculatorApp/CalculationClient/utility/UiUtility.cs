using CalculationLibrary;

namespace CalculationClient.utility
{
    static class UiUtility
    {
        public static void PrintMenu()
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
        }

        public static int GetChoice()
        {
            Console.Write("\nEnter choice[1/2/3/4]: ");
            return int.Parse(Console.ReadLine());
        }

        public static void GetValue(out int first, out int second)
        {
            Console.Write("\nEnter first value: ");
            first = int.Parse(Console.ReadLine());
            Console.Write("\nEnter second value: ");
            second = int.Parse(Console.ReadLine());
        }

        public static int? Calculate(int choice, out int first, out int second)
        {
            GetValue(out first, out second);
            Calculation calculation = new Calculation();
            int? result = null;
            switch (choice)
            {
                case 1:
                    result = calculation.Add(first, second);
                    break;

                case 2:
                    result = calculation.Subtract(first, second);
                    break;

                case 3:
                    result = calculation.Multiply(first, second);
                    break;

                case 4:
                    result = calculation.Divide(first, second);
                    break;

                default:

                    break;
            }
            return result;
        }

        public static void ChangeDecisionToContinue(ref char decision)
        {
            Console.Write("\nLike to continue?[y/Y]: ");
            decision = char.Parse(Console.ReadLine());
            if (char.IsUpper(decision))
                decision = char.ToLower(decision);
        }
    }
}
