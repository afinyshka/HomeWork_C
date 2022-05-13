// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("In this program you will see a random day of the week. If it's the weekend you are lucky! Press ENTER to start: ");
Console.ReadLine();
int number = new Random().Next(1,8);
if (number == 1) 
{
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("The day is Monday. ");
}
else if (number == 2) 
{
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("The day is Tuesday. ");
}
else if (number == 3)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("The day is Wednesday. ");
}
else if (number == 4)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("The day is Thursday. ");

}
else if (number == 5)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("The day is Friday. ");
}
else if (number == 6)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("The day is Saturday. ");
}
else if (number == 7)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write("The day is Sunday. ");
}
Console.ForegroundColor = ConsoleColor.DarkGray;
if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5)
{
Console.WriteLine("It's not the weekend.");
}
else if (number == 6 || number == 7 )
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("It's the weekend! Hooray! ");
}