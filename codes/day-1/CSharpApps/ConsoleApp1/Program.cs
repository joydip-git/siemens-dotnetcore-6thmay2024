using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dotnet legacy framework");
            Class1 cls = new Class1();
            Console.WriteLine(cls.Get());
        }
    }
}
