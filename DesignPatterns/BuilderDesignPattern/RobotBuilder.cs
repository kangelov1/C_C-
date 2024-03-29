﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public interface RobotBuilder
    {
       void buildRobotHead();
       void buildRobotTorso();
       void buildRobotArms();
       void buildRobotLegs();
       Robot getRobot();
    }
}
