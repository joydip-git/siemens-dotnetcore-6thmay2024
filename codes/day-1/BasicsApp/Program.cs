//z => optional argument with default value
// all optional arguments should be mentioned after all the fixed arguments (i.e., optional arguments should be the last ones in the argument list)
//an out variable can't be optional, because it can't have default value
//out variable must be assigned in the called function
static void Swap(int x, ref int y, out int m, int z = 0)
{
    x = 10;
    y = 20;
    z = 30;
    m = 40;
    //string interpolation
    Console.WriteLine($"{x}, {y}, {z}, {m}");
}

int a = 1;
int b = 2;
int c = 3;
int d;

//Named arguments
//Swap(x: a, y: b, m: c);
//Swap(y: b, z: c, x: a);

//passing by value
//Swap(y: b, x: a, z: c);

//passing by out and ref
Swap(y: ref b, x: a, z: c, m: out d);

//you can't pass any unassigned variable to a method argument
//Swap(x: a, z: c, y: ref b, m: d);



//Console.WriteLine(a + " " + b + " " + c);
//placeholder string
Console.WriteLine("{0}, {1}, {2}, {3}", a, b, c, d);


Console.Write("enter your date of birth in mm/dd/yyyy format: ");
string dob = Console.ReadLine();
//DateTime dateOfBirth = DateTime.Parse(dob);
//Console.WriteLine(dateOfBirth);
//DateTime dateOfBirth;
bool isPossible = DateTime.TryParse(dob, out DateTime dateOfBirth);
if (isPossible)
{
    Console.WriteLine(dateOfBirth);
}
else
    Console.WriteLine(dateOfBirth);