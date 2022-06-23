Point point1 = new Point(2, 3);
Point point2 = new Point(-4, 0);

Console.WriteLine($"({point1.x}, {point1.y})");
Console.WriteLine($"({point2.x}, {point2.y})");

Color pink = new Color(255, 182, 193);
Color yellow = Color.yellow;

Console.WriteLine($"Pink's rgb: {pink.r}, {pink.g}, {pink.b}");
Console.WriteLine($"Yellow's rgb: {yellow.r}, {yellow.g}, {yellow.b}");

void CreateEveryCardInstance() {
  foreach(CardColors color in Enum.GetValues(typeof(CardColors))) {
    foreach(CardRanks rank in Enum.GetValues(typeof(CardRanks))) {
      Console.WriteLine($"The {color} {rank}");
    }
  }
}
CreateEveryCardInstance();

void DoorThing() {
  Console.WriteLine("What should the passcode for your new door be?");
  int passcode = Int32.Parse(Console.ReadLine() ?? "0");
  Door customDoor = new Door(passcode);

  Console.WriteLine($"Would you like the door to be {DoorState.open}, {DoorState.closed}, or {DoorState.locked}");
  Enum.TryParse(Console.ReadLine(), out DoorState newDoorState);

  bool success = customDoor.ChangeDoorState(newDoorState, passcode);
  Console.WriteLine(success);
  if (success) Console.WriteLine($"You successfully changed the door to be {newDoorState}");
  else Console.WriteLine($"The door remains in the {customDoor.state} position and was not changed.");
}
DoorThing();

void PasswordChecker() {
  PasswordValidator validator = new PasswordValidator();
  Console.WriteLine("Enter a password");
  string password = Console.ReadLine();
  string validity = validator.PasswordIsValid(password) ? "valid" : "invalid";
  Console.WriteLine($"Your password is: {validity}");
}
PasswordChecker();