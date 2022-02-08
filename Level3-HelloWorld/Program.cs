Console.WriteLine("What is your name?");
string? playerName = Console.ReadLine() ?? null;

if (string.IsNullOrEmpty(playerName)) Console.WriteLine("Fine, I shall call you Billy Bob");
else Console.WriteLine($"Hello and welcome {playerName}!");

Console.WriteLine("-------------------");
Console.WriteLine("Bread is ready.");
Console.WriteLine("Who is the bread for?");

string? breadRecipient = Console.ReadLine() ?? null;
if (string.IsNullOrEmpty(breadRecipient)) Console.WriteLine("No bread for anyone now.");
else Console.WriteLine($"Noted: {breadRecipient} got bread.");
