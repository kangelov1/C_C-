using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class TestRobotBuilder
    {
        public static void Main()
        {
            RobotBuilder oldStyleRobot = new OldRobotBuilder();
            RobotEngineer robotEngineer = new RobotEngineer(oldStyleRobot);
            robotEngineer.makeRobot();
            Robot robot = robotEngineer.getRobot();
            Console.WriteLine(robot);
        }
    }
}
