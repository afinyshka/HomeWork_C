// Сформировать трехмерный массив не повторяющимися двузначными числами.
// Показать его построчно на экран выводя индексы соответствующего элемента

int[,,] CreateFill3DMatrix(int rows, int columns, int shelves)
{
    int[,,] matrix3d = new int[rows, columns, shelves];
    int minElemNumber = 10;
    int count = 0;
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            for (int k = 0; k < shelves; k++)
            {
                if (minElemNumber > 99)
                    count++;
                else
                {
                    matrix3d[i, j, k] = minElemNumber;
                    minElemNumber++;
                }
            }
    if (count > 0) Console.WriteLine("The matrix are out of the unique numbers ");
    return matrix3d;
}

void PrintMatrix3D(int[,,] matrix3d)
{
    int rowsLength = matrix3d.GetLength(0);
    int columnsLength = matrix3d.GetLength(1);
    int shelvesLength = matrix3d.GetLength(2);
    for (int i = 0; i < rowsLength; i++)
        for (int j = 0; j < columnsLength; j++)
            for (int k = 0; k < shelvesLength; k++)
                Console.WriteLine($"element[{i},{j},{k}] = {matrix3d[i, j, k]} ");
}

int[,,] matrix3d8003 = CreateFill3DMatrix(3, 5, 4);
PrintMatrix3D(matrix3d8003);