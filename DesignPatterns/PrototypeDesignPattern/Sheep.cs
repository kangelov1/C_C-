using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public class Sheep:Animal
    {
        private string name;
        private string sound;
        public Sheep(string name, string sound)
        {
            this.name = name;
            this.sound = sound;
        }
        public void makeSound()
        {
            Console.WriteLine(this.sound);
        }
    }
}
