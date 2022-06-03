// Написать программу, которая обменивает элементы первой строки и последней строки

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

void LastFirstRowChange(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int tmp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = tmp;
    }

}
Console.WriteLine("Initial Matrix: ");
int[,] matrix7001 = CreateFillMatrix(4, 5);
PrintMatrix(matrix7001);
Console.WriteLine("Changed elements matrix: ");
LastFirstRowChange(matrix7001);
PrintMatrix(matrix7001);
