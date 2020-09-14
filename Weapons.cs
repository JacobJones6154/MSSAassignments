using System;
using System.Collections.Generic;
using System.Text;

namespace UsingProp
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
            Console.WriteLine("Butter Butter Jam Jam Butter Butter Jam Jam"); //??? This is something we had to yell during dry fire training in Combat training so everytime i think of shooting this comes to mindl
        }
    }
    class SmallCaliberWeapon : Weapons
    {
        public override void Shoot()
        {
            Console.WriteLine("Pew Pew Pew Pew");
        }
    }
    class LargeCaliberWeapon : Weapons
    {
        public override void Shoot()
        {
            Console.WriteLine("BANG BANG BANG");
        }
    }
}

