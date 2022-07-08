public class Robot {
  public int x;
  public int y;
  public bool isPowered;
  public RobotCommand[] commands = new RobotCommand[3];

  public void Run() {
    foreach (RobotCommand command in commands) {
      command.Run(this);
      Console.WriteLine($"[{x} {y} {isPowered}]");
    }
  }
}