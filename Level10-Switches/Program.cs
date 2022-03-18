Console.Write(@"The following items are available:
1 - Rope
2 - Torches
3 - Climbing Equipment
4 - Clean Water
5 - Machete
6 - Canoe
7 - Food Supplies
What Number do you want to see the price of ? ");
string? choice = Console.ReadLine() ?? null;

Console.Write("What's you name? ");
string? buyerName = Console.ReadLine() ?? null;
bool discount = buyerName == "Totoro";

string response = choice switch {
  "1" => $"Rope cost {(discount ? (10/2) : 10)} gold",
  "2" => $"Torches cost {(discount ? (15/2) : 15)} gold",
  "3" => $"Climbing Equipment cost {(discount ? (25/2) : 25)} gold",
  "4" => $"Clean Water cost {(discount ? (1/2) : 1)} gold",
  "5" => $"Machete cost {(discount ? (20/2) : 20)} gold",
  "6" => $"Canoe cost {(discount ? (200/2) : 200)} gold",
  "7" => $"Food Supplies cost {(discount ? (1/2) : 1)} gold",
  _ => "Item Not Available"
};

Console.WriteLine(response);