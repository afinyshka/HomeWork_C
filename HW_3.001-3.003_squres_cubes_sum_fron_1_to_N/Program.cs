// Показать таблицу квадратов чисел от 1 до N

Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine($"Table of squares of numbers from 1 to {number} is: ");
for (int number1=1; number1<=number; number1++) Console.Write($"{number1*number1} ");
//for (int number1=1; number1<=number; number1++) Console.WriteLine($"{number1}^2={number1*number1} ");
Console.WriteLine();

// Найти кубы чисел от 1 до N

Console.WriteLine($"Table of cubes of numbers from 1 to {number} is: ");
for (int number1=1; number1<=number; number1++) Console.Write($"{number1*number1*number1} ");
//for (int number1=1; number1<=number; number1++) Console.WriteLine($"{number1}^3={number1*number1*number1} ");
Console.WriteLine();

// Найти сумму чисел от 1 до А

int sum = 0;
for (int number1=1; number1<=number; number1++) sum = sum + number1;
Console.WriteLine($"Summa of numbers from 1 to {number} is: {sum} ");