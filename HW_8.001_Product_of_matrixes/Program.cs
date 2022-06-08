// Найти произведение двух матриц. Число столбцов первой матрицы равно числу строк второй. columns1=rows2

int[,] CreateFillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
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

int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] product = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                product[i, j] = product[i, j] + matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return product;
}

Console.WriteLine("Enter number of rows in the first matrix: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter number of columns in the first matrix and number of rows in the second matrix: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter number of ccolumns in the second matrix: ");
int l = int.Parse(Console.ReadLine() ?? "0");
int[,] matrixOne = CreateFillMatrix(n, m);
int[,] matrixTwo = CreateFillMatrix(m, l);
Console.WriteLine("First matrix: ");
PrintMatrix(matrixOne);
Console.WriteLine("Second matrix: ");
PrintMatrix(matrixTwo);
int[,] matrixProduct = ProductMatrix(matrixOne, matrixTwo);
Console.WriteLine("Product matrix of the first and the second matrixes: ");
PrintMatrix(matrixProduct);
