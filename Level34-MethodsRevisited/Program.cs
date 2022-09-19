// SAFER NUMBER CRUNCHING
bool userEnteredNumber = false;
string getUserNumber () {
  Console.WriteLine("Enter a number");
  string input = Console.ReadLine();
  return input;
}

while (!userEnteredNumber) {
  string input = getUserNumber();
  if (int.TryParse(input, out int value)) {
    userEnteredNumber = true;
    Console.WriteLine($"You entered {value}");
  }
  else getUserNumber();
}
// SAFER NUMBER CRUNCHING