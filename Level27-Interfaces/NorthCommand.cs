public class NorthCommand : IRobotCommand {
  public void Run(Robot robot) {
    if (robot.isPowered) robot.y++;
  }
}