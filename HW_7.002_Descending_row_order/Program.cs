// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

int[,] CreateFillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
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

bool DescendingOrderRow(int[,] matrix) // Метод требует дополнительной сортировки, но работает
{
    bool kSort = false;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j - 1] < matrix[i, j])
            {
                int tmp = matrix[i, j - 1];
                matrix[i, j - 1] = matrix[i, j];
                matrix[i, j] = tmp;
                kSort = true;
            }
        }
    }
    return kSort;
}

void DescendingOrderRowFull(int[,] matrix) // Самостоятелньо работающий метод
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] < matrix[i, k])
                {
                    int tmp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = tmp;
                }
            }
        }
    }
}


Console.WriteLine("Initial Matrix: ");
int[,] matrix7002 = CreateFillMatrix(3, 10);
PrintMatrix(matrix7002);
Console.WriteLine("Descending order matrix Full: ");
DescendingOrderRowFull(matrix7002);
PrintMatrix(matrix7002);

// проверка неполностью рабочего метода
Console.WriteLine("Descending order matrix: ");
bool check = DescendingOrderRow(matrix7002);
while (check == true) check = DescendingOrderRow(matrix7002); // проверка необходимости дополнительной сортировки
PrintMatrix(matrix7002);