// Подсчитать сумму цифр в числе

Console.WriteLine("Enter a number: ");
int number = Math.Abs(int.Parse(Console.ReadLine()?? "0"));
int digitsSum = 0;
int numberFirst = number;
for (digitsSum = 0; number>=1; number=number/10) digitsSum = digitsSum + number%10;
Console.WriteLine($"Summa of digits in {numberFirst} equals {digitsSum} ");