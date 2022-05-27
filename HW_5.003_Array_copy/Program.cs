// Написать программу копирования массива

int[] FillArray (int [] array)
{
    var random = new Random ();
    for (int i=0; i<array.Length; i++)
    {
        array[i] = random.Next(0,10);
    }
    return array;
}

int[] CopyArray (int [] array)
{
    int [] arrayCopy = new int [array.Length];
    for (int i=0; i<array.Length; i++)
        arrayCopy[i] = array[i];
    return arrayCopy;
}

void PrintArray (int [] array)
{
    for (int i=0; i<array.Length; i=i+2)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int [] arrayFirst = new int [5];
FillArray(arrayFirst);
int [] arraySecond = CopyArray (arrayFirst);
Console.WriteLine("Initial array: ");
PrintArray (arrayFirst);
Console.WriteLine();
Console.WriteLine("Copied array: ");
PrintArray (arraySecond);


//---------------------------------------------------------------------------------------

//Alternative idea:

// Console.Clear();
// Console.WriteLine("Enter number of array elements: ");
// int number = int.Parse(Console.ReadLine() ?? "0");
// int[] arrayInitial = new int[number];
// int i = 0;
// for (i = 0; i < arrayInitial.Length; i++) arrayInitial[i] = new Random().Next(0, 10);
// Console.WriteLine();

// Console.WriteLine($"Initial {arrayInitial.Length}-elements array: ");
// for (i = 0; i < arrayInitial.Length; i++) Console.Write($"{arrayInitial[i]} ");
// Console.WriteLine();

// Console.WriteLine($"Copy {number}-elements array: ");
// int[] arrayCopy = new int[number];
// for (i = 0; i < arrayCopy.Length; i++) arrayCopy[i] = arrayInitial[i];
// for (i = 0; i < arrayCopy.Length; i++) Console.Write($"{arrayCopy[i]} ");
// Console.WriteLine();