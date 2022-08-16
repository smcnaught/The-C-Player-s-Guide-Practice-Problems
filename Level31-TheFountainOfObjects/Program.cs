Room entrance = new Room(0, 0);
Room fountain = new Room(2, 0);
bool fountainOn = false;

void StartGame() {
  bool playerWon = false;
  PlayerLocation playerLocation = new PlayerLocation(entrance.column, entrance.row);

  while (!playerWon) {
    Console.WriteLine("------------------------------------------");
    Console.WriteLine(playerLocation.GetPlayerLocation());
    string roomInfo = playerLocation.SenseTheRoom(entrance, fountain, fountainOn);
    if (roomInfo != "") Console.WriteLine(roomInfo);

    if (playerLocation.PlayerAtExit(entrance) && fountainOn) {
      Console.WriteLine("You win!");
      playerWon = true;
    }
    else {
      Console.Write(@"What do you want to do?
        1 - move north
        2 - move east
        3 - move south
        4 - move west
        5 - enable fountain
      ");
    
      string? choice = Console.ReadLine() ?? null;

      switch(choice) {
        case "1": playerLocation.MoveNorth(); break;
        case "2": playerLocation.MoveEast(); break;
        case "3": playerLocation.MoveSouth(); break;
        case "4": playerLocation.MoveWest(); break;
        case "5": EnableFountain(playerLocation); break;
        default: Console.WriteLine("Invalid choice"); break;
      }
    }
  }
}

void EnableFountain(PlayerLocation playerLocation) {
  if (playerLocation.PlayerAtFountain(fountain)) {
    fountainOn = true;
  }
  else Console.WriteLine("You are not in the Fountain Room; the fountain remains disabled");
}

StartGame();