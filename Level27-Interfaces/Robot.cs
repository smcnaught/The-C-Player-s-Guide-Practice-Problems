public class Robot {
  public int x;
  public int y;
  public bool isPowered;
  public IRobotCommand[] commands = new IRobotCommand[3];

  public void Run() {
    foreach (IRobotCommand command in commands) {
      command.Run(this);
      Console.WriteLine($"[{x} {y} {isPowered}]");
    }
  }
}