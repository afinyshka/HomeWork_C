// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine()?? "0");
if (number%2==0)
Console.WriteLine($"Cube of number of {number} is: {number*number*number} ");
else
Console.WriteLine($"Number {number} is uneven! ");