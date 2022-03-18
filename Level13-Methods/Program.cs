Console.WriteLine("Taking A Number");
int userNumber = AskForNumber("Please enter a number");
Console.WriteLine($"You entered: {userNumber}");

int userNumberInRange = AskForNumberInRange("Please enter a number between 1 and 50", 1, 50);
Console.WriteLine($"You entered: {userNumberInRange}");

int AskForNumber(string text) {
  Console.WriteLine(text);
  int numberResponse = Int32.Parse(Console.ReadLine() ?? "0");
  return numberResponse;
}

int AskForNumberInRange(string text, int min, int max) {
  int numberResponse = min - 1;
  while (numberResponse < min || numberResponse > max) {
    Console.WriteLine(text);
    numberResponse = Int32.Parse(Console.ReadLine() ?? "0");
  }

  return numberResponse;
}

Console.WriteLine("--------------------------------");
Console.WriteLine("Countdown");

int num = 10;
void Countdown() {
  Console.WriteLine(num);
  if (--num > 0) Countdown();
}

Countdown();