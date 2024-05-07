//using CalculationClient.utility;

//static import (import the static class itself)
using static CalculationClient.utility.UiUtility;
using CalculationLibrary;

char decisionToContinue = 'n';
do
{
    PrintMenu();
    int choice = GetChoice();
    //int first;
    //int second;
    int? result = Calculate(choice, out int first, out int second);
    if (result != null)
        Console.WriteLine($"\nResult: {result}");
    else
        Console.WriteLine("\ncould not perform opreation...");

    ChangeDecisionToContinue(ref decisionToContinue);

} while (decisionToContinue == 'y');