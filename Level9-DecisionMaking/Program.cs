Console.WriteLine("Repairing The Clocktower");
Console.Write("Enter a number ");
int myNum = Int32.Parse(Console.ReadLine());
bool isEven = myNum % 2 == 0;
if (isEven) Console.WriteLine("Tick");
else Console.WriteLine("Tock");

Console.WriteLine("------------------------");

Console.WriteLine("Watchtower");
Console.Write("X Value? ");
int x = Int32.Parse((Console.ReadLine()));

Console.Write("Y Value? ");
int y = Int32.Parse((Console.ReadLine()));

string northSouth = y >= 0 ? "north" : "south";
string eastWest = x >= 0 ? "east" : "west";

Console.WriteLine($"The enemy is to the {northSouth}{eastWest}");
