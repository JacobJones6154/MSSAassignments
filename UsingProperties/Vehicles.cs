using System;
using System.Collections.Generic;
using System.Text;

namespace UsingProperties
{
    class Vehicles
    {
        private string _name;
        private string _type;
        private int _capacity;

        public string Name
        {
            get => this._name;
            set => this._name = value;
        }
        public string Type
        {
            get => this._type;
            set => this._type = value;
        }
        public int Capacity
        {
            get => this._capacity;
            set => this._capacity = value;
        }
        public virtual void Movement()
        {
            Console.WriteLine("Moving");
        }
    }
    class Aircraft : Vehicles
    {
        public override void Movement()
        {
            Console.WriteLine("Flying");
        }
    }
    class Ships : Vehicles
    {
        public override void Movement()
        {
            Console.WriteLine("Sailing");
        }
    }
    class Tanks : Vehicles
    {
        public override void Movement()
        {
            Console.WriteLine("TANKS!");
        }
    }
}
