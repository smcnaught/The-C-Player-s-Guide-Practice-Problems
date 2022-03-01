Console.WriteLine("What is the base size of your triangle?");
string? triangleBase = Console.ReadLine() ?? null;

Console.WriteLine("What is the height of your triangle?");
string? triangleHeight = Console.ReadLine() ?? null;

if (!String.IsNullOrWhiteSpace(triangleBase) && !String.IsNullOrWhiteSpace(triangleHeight)) {
  int triangleArea = (Int32.Parse(triangleBase) * Int32.Parse(triangleHeight)) / 2;
  Console.WriteLine($"The area of your triangle is: {triangleArea}");
}
else {
  Console.WriteLine("You must enter a valid base and height to calculate the area.");
}

Console.WriteLine("=============================================================");
Console.WriteLine("Integer Vs. Floating Point Division");
int a = 5;
int b = 2;
int result = a / b;
Console.WriteLine(result); // result = 2

float c = 5;
float d = 2;
float res = c / d;
Console.WriteLine(res); // res = 2.5
Console.WriteLine("=============================================================");

Console.WriteLine("The Four Sisters And The Duckbear");
Console.WriteLine("How many chocolate eggs were gathered today?");
string? eggCount = Console.ReadLine() ?? null;
int numberOfSisters = 4;

if (!String.IsNullOrWhiteSpace(eggCount)) {
  int numberOfEggs = Int32.Parse(eggCount);
  int eggsForEachSis = numberOfEggs / numberOfSisters;
  int eggsForDucky = numberOfEggs % numberOfSisters;
  Console.WriteLine($"Eggs for each sister: {eggsForEachSis}");
  Console.WriteLine($"Eggs for duck bear: {eggsForDucky}");
}

Console.WriteLine("=============================================================");
Console.WriteLine("The Dominion of Kings");
int estateWorth = 1;
int duchyWorth = 1;
int provinceWorth = 1;
Console.WriteLine("How many estates do you have?");
string? totalEstatesRes = Console.ReadLine() ?? null;
int totalEstates = 0;
if (!String.IsNullOrWhiteSpace(totalEstatesRes)) totalEstates = Int32.Parse(totalEstatesRes);

Console.WriteLine("How many duchies do you have?");
string? totalDuchiesRes = Console.ReadLine() ?? null;
int totalDuchies = 0;
if (!String.IsNullOrWhiteSpace(totalDuchiesRes)) totalDuchies = Int32.Parse(totalDuchiesRes);

Console.WriteLine("How many provinces do you have?");
string? totalProvincesRes = Console.ReadLine() ?? null;
int totalProvinces = 0;
if (!String.IsNullOrWhiteSpace(totalProvincesRes)) totalProvinces = Int32.Parse(totalProvincesRes);

int totalScore = (estateWorth * totalEstates) + (duchyWorth * totalDuchies) + (provinceWorth * totalProvinces);
Console.WriteLine($"Your point total is: {totalScore}");
Console.WriteLine("=============================================================");
