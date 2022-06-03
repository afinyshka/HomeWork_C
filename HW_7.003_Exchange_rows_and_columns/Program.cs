// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить,
// что это невозможно (в случае, если матрица не квадратная).

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

void RowColumnsELementsChange(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            int tmp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = tmp;
        }
    }
}
Console.WriteLine("Initial Matrix: ");
int[,] matrix7003 = CreateFillMatrix(7, 7);
PrintMatrix(matrix7003);
Console.WriteLine();
if (matrix7003.GetLength(0) == matrix7003.GetLength(1))
{
    Console.WriteLine("Changed elements matrix: ");
    RowColumnsELementsChange(matrix7003);
    PrintMatrix(matrix7003);
}
else Console.WriteLine($"Elements in matrix can't be changed. The matrix '{"matrix7003"}' is not rectangle! ");
Console.WriteLine();
Console.WriteLine("Initial Matrix: ");
int[,] matrix73 = CreateFillMatrix(5, 15);
PrintMatrix(matrix73);
Console.WriteLine();
if (matrix7003.GetLength(0) == matrix73.GetLength(1))
{
    Console.WriteLine("Changed elements matrix: ");
    RowColumnsELementsChange(matrix73);
    PrintMatrix(matrix73);
}
else Console.WriteLine($"Elements in matrix can't be changed. The matrix '{"matrix73"}' is not a rectangle matrix! ");

