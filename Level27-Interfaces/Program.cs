Robot robot = new Robot();

Console.WriteLine("What would you like to do to your robot?");
Console.WriteLine();
Console.WriteLine("1. on");
Console.WriteLine("2. off");
Console.WriteLine("3. north");
Console.WriteLine("4. south");
Console.WriteLine("5. east");
Console.WriteLine("6. west");

int response1 = Int32.Parse(Console.ReadLine() ?? "0");
int response2 = Int32.Parse(Console.ReadLine() ?? "0");
int response3 = Int32.Parse(Console.ReadLine() ?? "0");

robot.commands[0] = GetChosenCommand(response1);
robot.commands[1] = GetChosenCommand(response2);
robot.commands[2] = GetChosenCommand(response3);

IRobotCommand GetChosenCommand(int userResponse) {
  IRobotCommand chosenCommand = new OnCommand();
  bool userResponded = true;
  switch(userResponse) {
    case 1:
      chosenCommand = new OnCommand();
      break;
    case 2:
      chosenCommand = new OffCommand();
      break;
    case 3:
      chosenCommand = new NorthCommand();
      break;
    case 4:
      chosenCommand = new SouthCommand();
      break;
    case 5:
      chosenCommand = new EastCommand();
      break;
    case 6:
      chosenCommand = new WestCommand();
      break;
    default: 
      userResponded = false;
      break;
  }

  if (!userResponded) {
     Console.WriteLine("Choose a command dummy");
     return new OffCommand();
  }
  
  return chosenCommand;
}

robot.Run();