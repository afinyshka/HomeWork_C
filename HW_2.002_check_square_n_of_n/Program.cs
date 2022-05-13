// По двум заданным числам проверять является ли одно квадратом другого:
Console.WriteLine("Enter first number:");
int n1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter second number:");
int n2 = int.Parse(Console.ReadLine() ?? "0");
if (n1 == n2*n2 || n2 == n1*n1)
{
    if (n1>n2) Console.WriteLine($"Number {n1} is a square of number {n2}. ");
    else if (n2>n1) Console.WriteLine($"Number {n2} is a square of number {n1}. ");
}
 else Console.WriteLine($"None of the numbers {n1} and {n2} is a square of the other. ");