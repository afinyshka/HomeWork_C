// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите трёхзначное число: ");
int n = int.Parse(Console.ReadLine());
if (n > 99 && n < 1000 || n > -1000 && n < -99)
{
Console.Write($"Полученное двузначное число = {n/100}");
Console.WriteLine(Math.Abs(n%10));
}
else 
Console.WriteLine("Введено не трёхзначное число! ");