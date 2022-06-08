// Показать треугольник Паскаля. *Сделать вывод в виде равнобедренного треугольника

int[,] CreatePascaleTriangle(int rows)
{
    int[,] matrix = new int[rows, rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            if (j==0) matrix[i, j] = 1;
            else matrix[i, j] = matrix[i-1, j-1]+matrix[i-1, j];
            if (i==j) break;
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

void MatrixZeroChange (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == 0) Console.Write(" ");
            else Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Enter number of rows and columns in the matrix: ");
int m = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix8004 = CreatePascaleTriangle(m);
Console.WriteLine("Initial matrix: ");
PrintMatrix(matrix8004);
Console.WriteLine("Pascale matrix: ");
MatrixZeroChange(matrix8004);