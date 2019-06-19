using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class RobotEngineer
    {
        private RobotBuilder robotBuilder;
        public RobotEngineer(RobotBuilder robotBuilder)
        {
            this.robotBuilder = robotBuilder;
        }
        public Robot getRobot()
        {
            return this.robotBuilder.getRobot();
        }
        public void makeRobot()
        {
            this.robotBuilder.buildRobotHead();
            this.robotBuilder.buildRobotArms();
            this.robotBuilder.buildRobotTorso();
            this.robotBuilder.buildRobotLegs();
        }
    }
}
