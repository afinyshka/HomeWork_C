// Задать номер четверти, показать диапазоны для возможных координат:
Console.WriteLine("Specify a quarter number to see its coordinates: I, II, III, IV ");
string quarter = Console.ReadLine() ?? "0";
if (quarter.ToLower() == "i" || quarter == "1") Console.WriteLine($"Quarter I: x>0, y>0. ");
else if (quarter == "ii"|| quarter == "2") Console.WriteLine($"Quarter II: x<0, y>0. ");
else if (quarter == "iii" || quarter == "3") Console.WriteLine($"Quarter III: x<0, y<0. ");
else if (quarter == "iv" || quarter == "4") Console.WriteLine($"Quarter IV: x>0, y<0. ");
else Console.WriteLine ("Specified number is incorrect ");