// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

Console.WriteLine("8-elements array: ");
int [] array8 = new int [8];
for (int i=0; i<array8.Length; i++) array8[i] = new Random().Next(0,2);
for (int i=0; i<array8.Length; i++) Console.Write($"{array8[i]} ");
Console.WriteLine();

// Mассив из N элементов, заполненных нулями и единицами вывести их на экран

Console.WriteLine("Enter number of array elements: ");
int number = int.Parse(Console.ReadLine()?? "0");
int [] array00 = new int [number];
Console.WriteLine($"{number}-elements array: ");
for (int i=0; i<array00.Length; i++) Console.Write($"{new Random().Next(0,2)} ");
Console.WriteLine();