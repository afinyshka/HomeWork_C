// Показать двумерный массив размером m×n заполненный вещественными числами:

double[,] CreateMatrix (int rows, int columns, int minRandom, int maxRandom)
{
    double [,] matrix = new double [rows, columns];
    var random = new Random(); //new Random().Next(10,100);
    for (int i=0; i<rows; i++)
    {
         for (int j=0; j<columns; j++)
         matrix [i,j] = random.Next(minRandom, maxRandom)*random.NextDouble(); //домножили на k = 0,0 ... 1,0
    }
    return matrix;
}

void PrintMatrix (double [,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
         for (int j=0; j<matrix.GetLength(1); j++) Console.Write($"{matrix[i,j]} ");
    Console.WriteLine();
    }
}

Console.Clear();
double[,] matrix61 = CreateMatrix (3, 4, 1, 100);
PrintMatrix (matrix61);