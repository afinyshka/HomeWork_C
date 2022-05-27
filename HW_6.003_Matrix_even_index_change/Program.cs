// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int[,] FillMatrix(int rows, int columns, int minRandom, int maxRandom)
{
    int[,] matrix = new int[rows, columns];
    var rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            matrix[i, j] = rand.Next(minRandom, maxRandom);
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ChandeEvenIndexsElem(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) matrix[i, j] = matrix[i, j] * matrix[i, j];
        }
    }
}

Console.Clear();
Console.WriteLine("Enter amount of rows in the matrix: ");
int rowsNum = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter amount of columns in the matrix: ");
int columnsNum = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter minimun number of random diaposon: ");
int minRand = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter maximum number of random diaposon: ");
int maxRand = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix63 = FillMatrix(rowsNum, columnsNum, minRand, maxRand);
Console.WriteLine();
PrintMatrix(matrix63);
ChandeEvenIndexsElem(matrix63);
Console.WriteLine();
PrintMatrix(matrix63);