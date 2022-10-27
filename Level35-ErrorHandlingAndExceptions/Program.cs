Random random = new Random();
int oatmealCookie = random.Next(0, 10);

try {
  List<int> playerPicks = new List<int>();
  while (true) {
    Console.WriteLine("Enter a number between 0 and 9. Do it! Do it now!");

    bool isOriginalNumber = false;
    int playerPick = 0;
    while (!isOriginalNumber) {
      playerPick = Int32.Parse(Console.ReadLine() ?? "0");
      if (playerPicks.Contains(playerPick)) {
        Console.WriteLine("You already chose that number, dummy. Pick again (0-9) plz.");
      }
      else {
        isOriginalNumber = true;
      }
    }

    if (playerPick == oatmealCookie) {
      throw new Exception("You found the devil cookie (secretly delicious but whatever you lose)");
    }
  }
}
catch(Exception e) {
  Console.WriteLine(e.Message);
}