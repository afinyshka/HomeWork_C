// Показать четные числа от 1 до N
Console.WriteLine("Введите число > 1: ");
int n = int.Parse(Console.ReadLine());
int n1 = 1;
if (n < 1) Console.WriteLine("Введённое значение не удовлетворяет условию 'Введите число > 1' ");
else Console.WriteLine($"Четные числа в интервале от 1 до {n}: ");
while (n1 <= n)
{
  if (n1%2 == 0)
  {
  Console.Write($"{n1} ");
  }
n1++;
}