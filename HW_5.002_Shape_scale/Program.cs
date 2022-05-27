// Написать программу масштабирования фигуры
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
//например: "(0,0) (2,0) (2,2) (0,2)"
//коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
//В результате показать координаты, которые получатся.
//при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

double[] FillArray (double [] array, int numberOfElem)
{
    
    for (int i=0; i<array.Length; i++)
    {
        if (i%2==0) Console.WriteLine($"Enter coordinates of the shape's point number {i/2+1}: ");
        array[i] = int.Parse(Console.ReadLine()?? "0");
    }
    return array;
}

double[] ScopeArray (double [] array, double [] arrayCopy, double k, int numberOfElem)
{
    for (int i=0; i<arrayCopy.Length; i++)
        arrayCopy[i] = array[i]*k;
    return arrayCopy;
}

void PrintArray (double [] array)
{
    for (int i=0; i<array.Length; i=i+2)
        Console.Write($"({array[i]}; {array[i+1]}) ");
    Console.WriteLine();
}

Console.WriteLine("Enter number of the shape points: ");
int n = int.Parse(Console.ReadLine()?? "0");
int numberOfElem = n*2;
double [] initialArray = new double[numberOfElem];
Console.WriteLine("Enter coefficient k to scale the shape: ");
double k = double.Parse(Console.ReadLine()?? "0");
FillArray (initialArray, numberOfElem);
double [] scaledArray = new double[numberOfElem];
ScopeArray (initialArray, scaledArray, k, numberOfElem);
Console.WriteLine("Entered shape's coordinates: ");
PrintArray(initialArray);
Console.WriteLine();
Console.WriteLine($"Coefficien of scaling k = {k} ");
Console.WriteLine("Scaled shape's coordinates: ");
PrintArray(scaledArray);

// Console.WriteLine("Enter coordinates for the first point: ");
// Console.WriteLine("Enter coordinates x1: ");
// double x1 = double.Parse(Console.ReadLine()?? "0");
// Console.WriteLine("Enter coordinates y1: ");
// double y1 = double.Parse(Console.ReadLine()?? "0");
// Console.WriteLine("Enter coordinates for the second point: ");
// Console.WriteLine("Enter coordinates x2: ");
// double x2 = double.Parse(Console.ReadLine()?? "0");
// Console.WriteLine("Enter coordinates y2: ");
// double y2 = double.Parse(Console.ReadLine()?? "0");
// Console.WriteLine("Enter coordinates for the second point: ");
// Console.WriteLine("Enter coordinates x3: ");
// double x3 = double.Parse(Console.ReadLine()?? "0");
// Console.WriteLine("Enter coordinates y3: ");
// double y3 = double.Parse(Console.ReadLine()?? "0");
// Console.WriteLine($"({x1};{y1}) ({x2};{y2}) ({x3};{y3}) ");
// Console.WriteLine("Enter coefficient k to scale the shape: ");
// double k = double.Parse(Console.ReadLine()?? "0");
// x1= k*x1;
// y1= k*y1;
// x2= k*x2;
// y2= k*y2;
// x3= k*x3;
// y3= k*y3;
// Console.WriteLine($"Shape points with k = {k}: ");
// Console.WriteLine($"({x1};{y1}) ({x2};{y2}) ({x3};{y3}) ");