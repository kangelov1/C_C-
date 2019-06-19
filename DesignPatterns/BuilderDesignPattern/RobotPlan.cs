using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public interface RobotPlan
    {
        void setRobotHead(string head);
        void setRobotArms(string arms);
        void setRobotTorso(string torso);
        void setRobotLegs(string legs);
    }
}
