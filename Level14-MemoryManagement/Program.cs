Console.WriteLine("Hunting The Manticore");

int manticoreHealth = 10;
int cityHealth = 15;
int round = 1;

Console.WriteLine("Player 1, how far away from the city do you want to station the Manticore? (0-100)");
int manticoreDistanceFromCity = Int32.Parse(Console.ReadLine() ?? "0");
Console.Clear();

Console.WriteLine("Player 2, it is your turn.");
Console.WriteLine("--------------------------------------------------------------------");
while (manticoreHealth > 0 && cityHealth > 0) {
  int damage = GetDamage();
  Console.WriteLine($"STATUS: Round: {round}  City: {cityHealth}/15  Manticore: {manticoreHealth}/10");
  Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");

  int player2RangeGuess = GetRangeToTarget();
  
  string status = (player2RangeGuess > manticoreDistanceFromCity) ? "OVERSHOT the target."
                 :(player2RangeGuess < manticoreDistanceFromCity) ? "FELL SHORT of the target."
                 : "was a DIRECT HIT!";

  Console.WriteLine($"That round {status}");
  Console.WriteLine("--------------------------------------------------------------------");

  if (status == "was a DIRECT HIT!") manticoreHealth -= damage;
  if (manticoreHealth > 0) cityHealth--;
  round++;
}

if (manticoreHealth > 0) Console.WriteLine("The city of Consolas has been destroyed! The Manticore has been saved!");
else if (cityHealth > 0) Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");

int GetRangeToTarget() {
  Console.WriteLine("Enter desired cannon range: ");
  int numberResponse = Int32.Parse(Console.ReadLine() ?? "0");
  return numberResponse;
}

int GetDamage() {
  int damage = 0;
  bool isFire = round % 3 == 0;
  bool isElectric = round % 5 == 0;
  bool isBoth = isFire && isElectric;

  if (isBoth) damage = 10;
  else if (isFire) damage = 3;
  else if (isElectric) damage = 5;
  else damage = 1;

  return damage;
}
