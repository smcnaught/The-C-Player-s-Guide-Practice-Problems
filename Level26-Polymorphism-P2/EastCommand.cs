public class EastCommand : RobotCommand {
  public override void Run(Robot robot) {
    if (robot.isPowered) robot.x++;
  }
}