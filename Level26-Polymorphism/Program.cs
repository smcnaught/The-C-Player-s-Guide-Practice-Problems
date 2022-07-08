int maxItems = 10;
double maxWeight = 10;
double maxVolume = 10;
Pack pack = new Pack(maxItems, maxWeight, maxVolume);

Console.WriteLine("Which Item Would You Like to Add To Your Pack?");
Console.WriteLine();
Console.WriteLine("1. Arrow");
Console.WriteLine("2. Bow");
Console.WriteLine("3. Rope");
Console.WriteLine("4. Water");
Console.WriteLine("5. Food");
Console.WriteLine("6. Sword");

int response = Int32.Parse(Console.ReadLine() ?? "0");

bool addedItemSuccessfully = false;
bool userResponded = true;
switch(response) {
  case 1:
    addedItemSuccessfully = pack.AddItemToPack(new Arrow());
    break;
  default: 
    userResponded = false;
    break;
}

Console.WriteLine(pack.ToString());

if (addedItemSuccessfully) Console.WriteLine("Your item has been added");
else if (userResponded) Console.WriteLine("Your pack was too full");
else Console.WriteLine("Choose an item dummy");
