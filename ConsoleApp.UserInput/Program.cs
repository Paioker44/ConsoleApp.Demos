// See https://aka.ms/new-console-template for more information

string userName = string.Empty;
int userAge;
int retirementAge = 65;
//prompt for the user
Console.WriteLine("Please enter your name");
userName = Console.ReadLine();
Console.WriteLine("Please now enter your age");
userAge = Convert.ToInt32(Console.ReadLine());


//processing the data
int workingYearsRemaining = retirementAge - userAge;

//outputs for the results
if (userAge < retirementAge)
{

    Console.WriteLine($"Full name: {userName}");
    Console.WriteLine($"Age: {userAge}");
    Console.WriteLine(workingYearsRemaining + " years left to your retirement");
}
else
{
    Console.WriteLine("You already pass te retirement age");
}
