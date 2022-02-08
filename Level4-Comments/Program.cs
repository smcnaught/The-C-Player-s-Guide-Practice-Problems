Console.WriteLine("What kind of thing are we talking about?");
string? description1 = Console.ReadLine();

Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string? description2 = Console.ReadLine();

Console.WriteLine($"The {description2} {description1} of Doom 3000!");
