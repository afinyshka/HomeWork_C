// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("Hello, World!");
int n = new Random().Next(10,100);
Console.WriteLine($"Случайно выбранное число из интервала [10, 99] = {n} ");
int d1 = n/10;
int d2 = n%10;
int maxDigit = d1;
if (d2>d1) maxDigit = d2;
Console.WriteLine($"Наибольшая цифра числа: {maxDigit} ");