using System;

namespace UsingProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicles BasicVehicle = new Vehicles();
            BasicVehicle.Movement();
            Aircraft Helicopter = new Aircraft();
            Helicopter.Movement();
            Ships Boat = new Ships();
            Boat.Movement();
            Tanks Tank = new Tanks();
            Tank.Movement();
            Weapons BasicWeapon = new Weapons();
            BasicWeapon.Shoot();
            SmallCaliberWeapon M16 = new SmallCaliberWeapon();
            M16.Shoot();
            LargeCaliberWeapon M2_50Cal = new LargeCaliberWeapon();
            M2_50Cal.Shoot();
        }
    }
}
