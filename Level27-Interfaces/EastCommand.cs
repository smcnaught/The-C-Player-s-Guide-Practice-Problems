public class EastCommand : IRobotCommand {
  public void Run(Robot robot) {
    if (robot.isPowered) robot.x++;
  }
}