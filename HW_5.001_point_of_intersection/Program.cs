// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, 
// y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.WriteLine("Enter coefficients for the first equation y = k1 * x + b1: ");
Console.WriteLine("Enter coefficient k1: ");
double k1 = double.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Enter coefficient b1: ");
double b1 = double.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Enter coefficients for the second equation y = k2 * x + b: ");
Console.WriteLine("Enter coefficient k2: ");
double k2 = double.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Enter coefficient b2: ");
double b2 = double.Parse(Console.ReadLine()?? "0");
Console.WriteLine($"{k1} {b1} {k2} {b2} ");
if (k1 == k2) Console.WriteLine($"The graphs of linear functions are parallel. There is no intersection point. ");
else if (k1 == k2 && b1==b2) Console.WriteLine($"The graphs of linear functions are the same. ");
else
{
    double x = ( b2 -  b1) / ( k1 -  k2);
    double y = (k2*b1 - k1*b2)/(k2-k1);
    Console.WriteLine($"Intersection point of two equations is ({Math.Round(x,2)}; {Math.Round(y,2)}) ");
}