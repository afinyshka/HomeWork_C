// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Clear();
Console.WriteLine("Enter number of array elements: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int[] arrayInitial = new int[number];
//Console.WriteLine($"{number}-elements array: ");
int i = 0;
for (i = 0; i < arrayInitial.Length; i++) arrayInitial[i] = new Random().Next(0, 10);
//for (i = 0; i < arrayInitial.Length; i++) Console.Write($"{arrayInitial[i]} ");
Console.WriteLine();
int number2 = number / 2;
if (number % 2 != 0) number2 = number / 2 + 1;
int[] arrayFinish = new int[number2];
//Console.WriteLine($"number2 = {number2} ");
//Console.WriteLine($"i = {i} ");
int product = 1;
//int lenthArrInitial = arrayInitial.Length;
i = 0;
//Console.WriteLine($"i = {i} ");
int length1 = arrayInitial.Length;
for (i = 0; i < length1; i++)
{
    product = arrayInitial[i] * arrayInitial[length1 - 1];
    arrayFinish[i] = product;
    length1 = length1 - 1;
    //Console.WriteLine($"i = {i} , product = {product}, lenth1 = {length1} ");
}

Console.WriteLine($"Initial {arrayInitial.Length}-elements array: ");
for (i = 0; i < arrayInitial.Length; i++) Console.Write($"{arrayInitial[i]} ");
Console.WriteLine();
Console.WriteLine($"Finish {number2}-elements array: ");
for (i = 0; i < arrayFinish.Length; i++) Console.Write($"{arrayFinish[i]} ");
Console.WriteLine();