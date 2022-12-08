using System;
using System.Collections.Generic;
using System.Dynamic;

int currentRobotID = 0;
dynamic robot = new ExpandoObject();
robot.ID = ++currentRobotID;

Console.WriteLine("What would you like to name the robot?");
robot.Name = Console.ReadLine() ?? "Bobby Joe";
Console.WriteLine("How tall is this thing?");
robot.Height = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("How wide is this thing?");
robot.Width = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("What color is your robot?");
robot.Color = Console.ReadLine();

foreach (KeyValuePair<string, object> property in (IDictionary<string, object>)robot) {
  Console.WriteLine($"{property.Key}: {property.Value}");
}