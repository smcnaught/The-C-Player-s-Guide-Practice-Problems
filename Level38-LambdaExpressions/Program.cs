while (true) {
  Console.Write("Do you want to check if even(1), positive(2) or if your number is a multiple of ten(3)?");
  int filterChoice = Int32.Parse(Console.ReadLine() ?? "0");
  Sieve sieve = filterChoice switch {
    1 => new Sieve(x => x % 2 == 0),
    2 => new Sieve(x => x >= 0),
    3 => new Sieve(x => x % 10 == 0)
  };

  Console.Write("Which number would you like to check?");
  int playerNumber = Int32.Parse(Console.ReadLine() ?? "0");

  string goodOrBad = sieve.IsGood(playerNumber) ? "good" : "bad";
  Console.WriteLine($"Your number is {goodOrBad}");
}