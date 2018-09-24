using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Weapon
    {
        public void MachineGun()
        {
            Console.WriteLine($"This soldier is outfitted with a 240B");
        }
        public void Rifle()
        {
            Console.WriteLine("This soldier is outfitted with a m4 carbine");
        }
        public void Pistol()
        {
            Console.WriteLine("This soldier is outfitted with a M9");
        }
    }
}
