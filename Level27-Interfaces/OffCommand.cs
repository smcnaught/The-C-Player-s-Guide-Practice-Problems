public class OffCommand : IRobotCommand {
  public void Run(Robot robot) {
    robot.isPowered = false;
  }
}