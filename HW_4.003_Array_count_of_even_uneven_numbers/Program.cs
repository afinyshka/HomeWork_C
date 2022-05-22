// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

Console.WriteLine("Enter number of array elements: ");
int number = int.Parse(Console.ReadLine()?? "0");
int [] arrayFree = new int [number];
Console.WriteLine($"{number}-elements array: ");
for (int i=0; i<arrayFree.Length; i++) arrayFree[i] = new Random().Next(100,1000);
for (int i=0; i<arrayFree.Length; i++) Console.Write($"{arrayFree[i]} ");
// for (int i=0; i<arrayFree.Length; i++) Console.Write($"{new Random().Next(100,1000)} ");
Console.WriteLine();

int countEven = 0;
int countUneven = 0;
for (int i = 0; i<arrayFree.Length; i++)
{
    if (arrayFree[i]%2 != 0) countUneven++;
    else if (arrayFree[i]%2 == 0) countEven++;
}
Console.WriteLine($"Number of even numbers: {countEven} ");
Console.WriteLine($"Number of UNeven numbers: {countUneven} ");