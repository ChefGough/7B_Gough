using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Soldier
    {
        public void Officer()
        {
            Console.WriteLine("This soldier is an Officer");

        }
        public void EnlistedPrivate()
        {
            Console.WriteLine("this soldier is a Private");
        }
        public void EnlistedNCO()
        {
            Console.WriteLine("This soldier is an NCO");
        }
    }
}
