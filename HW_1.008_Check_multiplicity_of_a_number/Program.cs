// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1%number2 == 0) Console.WriteLine($"Число {number1} кратно числу {number2} ");
else if (number2%number1 == 0) Console.WriteLine($"Число {number2} кратно числу {number1} ");
else Console.WriteLine($"Числа {number1} и {number2} не кратны ");
