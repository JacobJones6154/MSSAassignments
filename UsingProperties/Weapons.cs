using System;
using System.Collections.Generic;
using System.Text;

namespace UsingProperties
{
    class Weapons
    {
        private string _name;
        private double _caliber;
        private string _type;

        public string Name
        {
            get => this._name;
            set => this._name = value;
        }
        public double Caliber
        {
            get => this._caliber;
            set => this._caliber = value;
        }
        public string Type
        {
            get => this._type;
            set => this._type = value;
        }
        public virtual void Shoot()
        {
            Console.WriteLine("Bang");
        }
    }
    class SmallCaliberWeapon : Weapons
    {
        public override void Shoot()
        {
            Console.WriteLine("Small Bang");
        }
    }
    class LargeCaliberWeapon : Weapons
    {
        public override void Shoot()
        {
            Console.WriteLine("Big Bang");
        }
    }
}
