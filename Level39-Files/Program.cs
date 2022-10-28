Console.WriteLine("Enter your name");
string playerName = Console.ReadLine();

int score = 0;
bool escapePressed = false;

bool userHasSaveFile = File.Exists(playerName + ".txt");
if (userHasSaveFile) {
  score = Int32.Parse(File.ReadAllText(playerName+".txt"));
}

while (!escapePressed) {
  Console.WriteLine("Hit any key. Hit escape to quit.");
  ConsoleKeyInfo keyInput = Console.ReadKey();
  if (keyInput.Key != ConsoleKey.Escape) {
    score++;
    Console.WriteLine($"You entered {keyInput.Key} - plus 1 to your score!");
  }
  else {
    escapePressed = true;
    File.WriteAllText(playerName+".txt", score.ToString());
    Console.WriteLine($"Your score is: {score}");
  }
}