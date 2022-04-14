BoxStates currentState = BoxStates.Locked;

while (true) {
  Console.WriteLine($"The chest is {currentState.ToString().ToLower()}. What do you want to do?");
  string userResponse = Console.ReadLine().ToLower();
  ChangeState(userResponse);
}

void ChangeState(string userResponse) {
  if (currentState == BoxStates.Open && userResponse == "close") currentState = BoxStates.Unlocked;
  else if (currentState == BoxStates.Unlocked && userResponse == "lock") currentState = BoxStates.Locked;
  else if (currentState == BoxStates.Locked && userResponse == "unlock") currentState = BoxStates.Unlocked;
  else if (currentState == BoxStates.Unlocked && userResponse == "open")  currentState = BoxStates.Open;
}