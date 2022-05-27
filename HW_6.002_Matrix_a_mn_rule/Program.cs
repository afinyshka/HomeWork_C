// Задать двумерный массив следующим правилом: Aₘₙ = m+n

int [,] FillMatrix (int rows, int columns)
{
    int [,] matrix = new int [rows, columns];
    for (int i=0; i<rows; i++)
    {
        for (int j=0; j<columns; j++)
        matrix [i,j] = i+j;
    }
    return matrix;
}

void PrintMatrix (int [,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix [i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Enter amount of rows: ");
int rowsNum = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter amount of columns: ");
int columnsNum = int.Parse(Console.ReadLine() ?? "0");
int [,] matrix62 = FillMatrix (rowsNum, columnsNum);
PrintMatrix (matrix62);