using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class OldRobotBuilder:RobotBuilder
    {
        private Robot robot;

        public OldRobotBuilder()
        {
            this.robot = new Robot();
        }
        public void buildRobotHead()
        {
            robot.setRobotHead("Tin Head");
        }

        public void buildRobotTorso()
        {
            robot.setRobotTorso("Tin Torso");
        }

        public void buildRobotArms()
        {
            robot.setRobotArms("Blowtorch");
        }

        public void buildRobotLegs()
        {
            robot.setRobotLegs("Roller Skates");
        }
        public Robot getRobot()
        {
            return this.robot;
        }
    }
}
