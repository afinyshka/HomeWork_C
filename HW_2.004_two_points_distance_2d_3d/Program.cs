// Найти расстояние между точками в пространстве 2D/3D:
Console.Clear();
Console.WriteLine("Enter first point coordinates (x,y,z): ");
Console.WriteLine("*if you want to calculate the distance between two 2d points, set the z coordinate to 0. ");

int Coordinate (string text)
{
    Console.WriteLine($"Enter point {text} coordinate. ");
    Console.Write($"{text} = ");
    int coordinateValue = int.Parse(Console.ReadLine() ?? "0");
    return coordinateValue;
}
int x1 = Coordinate ("x");
int y1 = Coordinate ("y");
int z1 = Coordinate ("z");

Console.WriteLine("Enter second point coordinates (x,y,z): ");

int x2 = Coordinate ("x");
int y2 = Coordinate ("y");
int z2 = Coordinate ("z");

// Console.WriteLine("Enter first point coordinates (x,y,z): ");
// Console.WriteLine("Enter point x coordinate. ");
// Console.Write("x = ");
// double x1 = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Enter point y coordinate. ");
// Console.Write("y = ");
// double y1 = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Enter point z coordinate. For 2d point z = 0 ");
// Console.Write("z = ");
// double z1 = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Enter second point coordinates (x,y,z): ");
// Console.WriteLine("Enter point x coordinate. ");
// Console.Write("x = ");
// double x2 = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Enter point y coordinate. ");
// Console.Write("y = ");
// double y2 = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Enter point z coordinate. For 2d point z = 0 ");
// Console.Write("z = ");
// double z2 = int.Parse(Console.ReadLine() ?? "0");

double distance = Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2) + Math.Pow((z1-z2), 2));
Console.WriteLine($"Distance between points ({x1}, {y1}, {z1}) and ({x2}, {y2}, {z2}) equals {distance} ");
