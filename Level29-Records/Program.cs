Sword originalSword = new Sword(Material.iron, Gemstone.none, 6, 4);
Sword sapphireSword = originalSword with { gemstone = Gemstone.sapphire };
Sword emeraldSword = originalSword with { gemstone = Gemstone.emerald };

Console.WriteLine(originalSword);
Console.WriteLine(sapphireSword);
Console.WriteLine(emeraldSword);