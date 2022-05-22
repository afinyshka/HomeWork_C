// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int [] array123 = new int [123];
Console.WriteLine("123-elements array: ");
for (int i=0; i<array123.Length; i++) array123[i] = new Random().Next(0,501);
for (int i=0; i<array123.Length; i++) Console.Write($"{array123[i]} ");
Console.WriteLine();
int countDiaposon = 0;
for (int i = 0; i<array123.Length; i++)
{
    if (array123[i]>=10 && array123[i]<=99)
    {
        countDiaposon++;
        //Console.WriteLine($"Element {i}: {array123[i]} ");
    }
}
Console.WriteLine($"Number of array's elements from diaposon [10;99]: {countDiaposon} ");