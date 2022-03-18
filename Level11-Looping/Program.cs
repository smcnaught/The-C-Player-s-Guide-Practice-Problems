Console.WriteLine("The Prototype");

Random random = new Random();
int pilotNumber = random.Next(1, 100);

Console.WriteLine("Enter a number between 1 and 100.");
int hunterGuess = Int32.Parse(Console.ReadLine() ?? "0");

while (hunterGuess != pilotNumber) {
  if (hunterGuess <= 0) {
    Console.WriteLine("Guess is not in range. Enter a number between 1 and 100.");
    hunterGuess = Int32.Parse(Console.ReadLine() ?? "0");
  }
  else if (hunterGuess < pilotNumber) {
    Console.WriteLine("Guess is too low. Try again.");
    hunterGuess = Int32.Parse(Console.ReadLine() ?? "0");
  }
  else if (hunterGuess > pilotNumber) {
    Console.WriteLine("Guess is too high. Try again.");
    hunterGuess = Int32.Parse(Console.ReadLine() ?? "0");
  }
}

Console.WriteLine("You guessed the number!");


Console.WriteLine("------------------------");
Console.WriteLine("The Challenge");
for (int i = 1; i < 101; i++) {
  bool isFire = i % 3 == 0;
  bool isElectric = i % 5 == 0;
  bool isBoth = isFire && isElectric;

  if (isBoth) Console.WriteLine($"{i}: Combined");
  else if (isFire) Console.WriteLine($"{i}: Fire");
  else if (isElectric) Console.WriteLine($"{i}: Electric");
  else Console.WriteLine($"{i}: Normal");
}