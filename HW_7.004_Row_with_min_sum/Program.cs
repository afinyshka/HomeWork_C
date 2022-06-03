// В прямоугольной матрице найти строку с наименьшей суммой элементов.

int[,] CreateFillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(0, 9);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    int rowsLength = matrix.GetLength(0);
    int columnsLength = matrix.GetLength(1);
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintMatrixColorRaw(int[,] matrix, int rawIndex)
{
    int rowsLength = matrix.GetLength(0);
    int columnsLength = matrix.GetLength(1);
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            if (i == rawIndex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{matrix[i, j]} ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{matrix[i, j]} ");
            }
        }Console.WriteLine();
    }
}

int[] RowMinSumElemSearch(int[,] matrix)
    {
        int[] array = new int[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int rowSum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                rowSum = rowSum + matrix[i, j];
            }
            array[i] = rowSum;
            //Console.Write($"{array[i]} ");
        }
        return array;
    }

    int MinFind(int[] array)
    {
        int indexMin = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[indexMin] > array[i]) indexMin = i;
        }
        return indexMin;
    }

    Console.WriteLine("Enter number raws number: ");
    int n = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Enter number columns number: ");
    int m = int.Parse(Console.ReadLine() ?? "0");
    int[,] matrix7004 = CreateFillMatrix(n, m);
    PrintMatrix(matrix7004);
    RowMinSumElemSearch(matrix7004);
    int[] rowSumArray = RowMinSumElemSearch(matrix7004);
    Console.WriteLine("Summa of the elements in the raws: ");
    for (int i = 0; i < rowSumArray.Length; i++)
        Console.Write($"{rowSumArray[i]} ");
    Console.WriteLine();
    Console.WriteLine($"Row with minimum sum of the elements is row number {MinFind(rowSumArray) + 1} ");

    PrintMatrixColorRaw(matrix7004, MinFind(rowSumArray));
