public class SouthCommand : RobotCommand {
  public override void Run(Robot robot) {
    if (robot.isPowered) robot.y--;
  }
}