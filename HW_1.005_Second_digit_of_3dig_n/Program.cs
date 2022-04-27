// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трёхзначное число: ");
int n = int.Parse(Console.ReadLine());
if (n > 99 && n < 1000)
Console.WriteLine($"Вторая цифра трёхзначного числа = {n/10%10} ");
else 
Console.WriteLine("Введено не трёхзначное число! ");


//if (n > 99 && n < 1000 || n > -1000 && n < -99)
//Console.WriteLine($"Вторая цифра трёхзначного числа = {Math.Abs(n/10%10)} ");