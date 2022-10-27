bool IsEven(int num) => num % 2 == 0;
bool IsPositive(int num) => num >= 0;
bool IsMultipleOfTen(int num) => num % 10 == 0;

while (true) {
  Console.Write("Do you want to check if even(1), positive(2) or if your number is a multiple of ten(3)?");
  int filterChoice = Int32.Parse(Console.ReadLine() ?? "0");
  Sieve sieve = filterChoice switch {
    1 => new Sieve(IsEven),
    2 => new Sieve(IsPositive),
    3 => new Sieve(IsMultipleOfTen)
  };

  Console.Write("Which number would you like to check?");
  int playerNumber = Int32.Parse(Console.ReadLine() ?? "0");

  string goodOrBad = sieve.IsGood(playerNumber) ? "good" : "bad";
  Console.WriteLine($"Your number is {goodOrBad}");
}