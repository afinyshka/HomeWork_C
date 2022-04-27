// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
if (n > 99 && n < 1000 || n > -1000 && n < -99)
Console.WriteLine($"Третья цифра трёхзначного числа = {n%10} ");
else if (n > -100 && n < 100)
Console.WriteLine("Введено число, в котором нет третьей цифры! ");
else
{
    while (n > 999 || n < -999)
    n=n/10;
Console.WriteLine($"Третья цифра четырехзначного или большего числа = {Math.Abs(n%10)} ");
}