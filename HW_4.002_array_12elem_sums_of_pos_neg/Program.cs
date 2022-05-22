// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
// исправила интервал на [-9,9]!!!

Console.WriteLine("12-elements array: ");
int [] array12 = new int [12];
for (int i=0; i<array12.Length; i++) array12[i] = new Random().Next(-9,10);
for (int i=0; i<array12.Length; i++) Console.Write($"{array12[i]} ");
Console.WriteLine();
int sumPositive = 0;
int sumNegative = 0;
for (int i = 0; i<array12.Length; i++)
{
    if (array12[i]>0) sumPositive = sumPositive + array12[i];
    if (array12[i]<0) sumNegative = sumNegative + array12[i];
}
Console.WriteLine($"Summs of positive elements = {sumPositive} ");
Console.WriteLine($"Summs of negative elements = {sumNegative} ");
if (sumPositive == 0) Console.WriteLine("There is no positive elements in the array");
if (sumPositive == 0) Console.WriteLine("There is no negative elements in the array");

int count0 = 0;
for (int i = 0; i<array12.Length; i++)
{
    if (array12[i]==0) count0++;
}
Console.WriteLine($"Number 0 occurs in the array {count0} time(s) ");
Console.WriteLine($"{12-count0} elements participated in addition ");

int countPositive = 0;
for (int i = 0; i<array12.Length; i++)
{
    if (array12[i] > 0) countPositive++;
}
Console.WriteLine($"Positive numbers occur in the array {countPositive} times ");

int countNegative = 0;
for (int i = 0; i<array12.Length; i++)
{
    if (array12[i] < 0) countNegative++;
}
Console.WriteLine($"Positive numbers occur in the array {countNegative} times ");