// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello and welcome to Vin Fletcher's Arrows!");

Arrow userArrow = new Arrow();

Console.WriteLine($"Would you like your arrowheads to be {ArrowheadType.Obsidian}, {ArrowheadType.Steel} or {ArrowheadType.Wood}?");
Enum.TryParse(Console.ReadLine(), out ArrowheadType typeResponse);
userArrow.SetArrowhead(typeResponse);

Console.WriteLine($"Would you like your arrow fletching to be made from {FletchingType.GooseFeathers}, {FletchingType.Plastic} or {FletchingType.TurkeyFeathers}?");
Enum.TryParse(Console.ReadLine(), out FletchingType fletchingResponse);
userArrow.SetFletching(fletchingResponse);

Console.WriteLine("How long would you like your arrows to be? (between 60-100cm)");
int lengthResponse = Int32.Parse(Console.ReadLine() ?? "0");
if (lengthResponse != 0) userArrow.SetArrowLength(lengthResponse);

Console.WriteLine($"Thank you! Your total is ${userArrow.GetCost()}");