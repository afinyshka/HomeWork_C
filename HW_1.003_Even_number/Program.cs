// Выяснить является ли число чётным (0 - является четным числом)
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number == 0) Console.WriteLine($"Как ни странно, но число {number} тоже четное! ");
else if (number % 2 == 0) Console.WriteLine($"Число {number} четное! ");
else Console.WriteLine($"Число {number} нечетное! ");
