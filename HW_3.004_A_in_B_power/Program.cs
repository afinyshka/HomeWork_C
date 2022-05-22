// Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Enter the power of the number: ");
int powerNumber = int.Parse(Console.ReadLine()?? "0");
int power=1;
if (powerNumber==0) Console.WriteLine($"Number {number} in power {powerNumber} equals {power} ");
else if (powerNumber>0)
{
    for (int number1=1; number1<=powerNumber; number1++) power=power*number;
    Console.WriteLine($"Number {number} in power {powerNumber} equals {power} ");    
}
else
{
    for (int number1=1; number1<=Math.Abs(powerNumber); number1++) power=power*number;
    Console.WriteLine($"Number {number} in power {powerNumber} equals 1/{power} ");    
}
