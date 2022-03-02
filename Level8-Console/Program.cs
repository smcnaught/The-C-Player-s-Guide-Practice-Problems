Console.Title = "Defense of Consolas";

Console.Write("Target Row? ");
int targetRow = Int32.Parse(Console.ReadLine());

Console.Write("Target Column? ");
int targetColumn = Int32.Parse(Console.ReadLine());

Console.WriteLine("Deploy to:");
Console.WriteLine($"({targetRow}, {targetColumn - 1})");
Console.WriteLine($"({targetRow - 1}, {targetColumn})");
Console.WriteLine($"({targetRow}, {targetColumn + 1})");
Console.WriteLine($"({targetRow + 1}, {targetColumn})");

Console.Beep();