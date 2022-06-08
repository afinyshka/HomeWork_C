// В двумерном массиве целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

int[,] CreateFillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(10, 100);
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

int[] MinElemMatrixFind(int[,] matrix)
{

    int[] minElemIndex = new int[2];
    int iMin = 0;
    int jMin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[iMin, jMin] > matrix[i, j])
            {
                iMin = i; jMin = j;
                //Console.WriteLine($"iMin = {iMin}");
                //Console.WriteLine($"jMin = {jMin}");
            }
        }
    }
    minElemIndex[0] = iMin;
    minElemIndex[1] = jMin;
    return minElemIndex;
}

int[,] DeliteRowInMatrix(int[,] matrix, int deliteRowIndex)
{
    int[,] matrixNew = new int[matrix.GetLength(0)-1, matrix.GetLength(1)];
    bool check = false;
    for (int i = 0; i < matrix.GetLength(0)-1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == deliteRowIndex)
            {
                check = true;
            }
            if (check == true) matrixNew[i, j] = matrix[i + 1, j];
            else matrixNew[i, j] = matrix[i, j];
        }
    }
    return matrixNew;
}

int[,] DeliteColumnInMatrix(int[,] matrix, int deliteColumnIndex)
{
    int[,] matrixNew = new int[matrix.GetLength(0), matrix.GetLength(1)-1];
    bool check = false;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            if (j == deliteColumnIndex)
            {
                check = true;
            }
            if (check == true) matrixNew[i, j] = matrix[i, j+1];
            else matrixNew[i, j] = matrix[i, j];
        }
    }
    return matrixNew;
}

Console.WriteLine("Enter number of rows in the matrix: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter number of columns in the matrix: ");
int m = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix8002 = CreateFillMatrix(n, m);
Console.WriteLine("First matrix: ");
PrintMatrix(matrix8002);
int[] minIndexes = MinElemMatrixFind(matrix8002);
Console.WriteLine($" i-index of the min element in the matrix is {MinElemMatrixFind(matrix8002)[0]}");
Console.WriteLine($" j-index of the min element in the matrix is {minIndexes[1]}");
Console.WriteLine("Delited row matrix: ");
int[,] matrixMinusRow = DeliteRowInMatrix(matrix8002, minIndexes[0]);
PrintMatrix(matrixMinusRow);
Console.WriteLine("Delited column matrix: ");
int[,] matrixMinusColumnMinusColumn = DeliteColumnInMatrix(matrixMinusRow, minIndexes[1]);
PrintMatrix(matrixMinusColumnMinusColumn);