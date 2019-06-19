using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class Robot:RobotPlan
    {
        private string head;
        private string arms;
        private string torso;
        private string legs;
        public void setRobotHead(string head)
        {
            this.head=head;
        }
        public string getRobotHead() { return this.head; }
        public void setRobotArms(string arms)
        {
            this.arms=arms;
        }
        public string getRobotArms() { return this.arms; }
        public void setRobotTorso(string torso)
        {
            this.torso = torso ;
        }
        public string getRobotTorso() { return this.torso; }
        public void setRobotLegs(string legs)
        {
            this.legs=legs;
        }
        public string getRobotLegs() { return this.legs; }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}",this.head,this.arms,this.torso,this.legs);
        }
    }
}
