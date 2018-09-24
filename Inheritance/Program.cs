using System;

namespace Inheritance
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Enlisted Mechanized Private");
            Soldier mySoldier = new Soldier();
            Vehicle myVehicle = new Vehicle();
            Weapon myWeapon = new Weapon();
            mySoldier.EnlistedPrivate();
            myVehicle.Stryker();
            myWeapon.MachineGun();

            Console.WriteLine("------------------------------------");

            Console.WriteLine("Enlisted Airborne NCO");
            mySoldier.EnlistedNCO();
            myVehicle.Airplane();
            myWeapon.Rifle();

            Console.WriteLine("------------------------------------");

            Console.WriteLine("Light infantry Officer");
            mySoldier.Officer();
            myVehicle.Hummvee();
            myWeapon.Pistol();
            
        }
        static void Main()
        {
           try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
