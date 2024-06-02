// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Different data types
/*
 text - string
 integers - int
 decimal - double, float, decimal
 logical - bool
 */

string name = "Paolo Villarello Murillo";
Console.WriteLine("im" + name);//string concatenation
Console.WriteLine($"I was given {name}d");//string interpolation
Console.WriteLine("they call me {0}", name);//formated string

int age = 54;
int retirementYearsLeft = 11;
Console.WriteLine("My age is "+age);


bool isTrue = true;
bool isFalse = false;
bool isRetired = false;
Console.WriteLine("im retired?" + isRetired);
