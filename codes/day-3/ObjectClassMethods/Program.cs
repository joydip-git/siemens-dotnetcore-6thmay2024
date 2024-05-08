//implcitly typed array
using ObjectClassMethods;

var numbers = new[] { 1, 2, 3 };

//implicitly typed local variable
var anilEmp = new Employee(1, "anil", 2000);
var sunilEmp = new Employee(1, "anil", 2000);

Console.WriteLine(anilEmp.ToString());

//if (anilEmp == sunilEmp)
if (anilEmp.Equals(sunilEmp))
{
    Console.WriteLine("same");
}
else
    Console.WriteLine("not same");


