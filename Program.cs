using System;

namespace UsingProp
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicles BasicVehicle = new Vehicles();
            BasicVehicle.Movement();
            Aircraft Helicopter = new Aircraft();
            Helicopter.Movement();
            Submersible Sub = new Submersible();
            Sub.Movement();
            Tanks Tank = new Tanks();
            Tank.Movement();
            Weapons BasicWeapon = new Weapons();
            BasicWeapon.Shoot();
            SmallCaliberWeapon AR15 = new SmallCaliberWeapon();
            AR15.Shoot();
            LargeCaliberWeapon MiniGun = new LargeCaliberWeapon();
            MiniGun.Shoot();
        }
    }
}
