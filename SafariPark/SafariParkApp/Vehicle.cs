using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp 
{
    public class Vehicle : iMoveable
    {
        private int _capacity;
        private int _numPassengers;

        public int NumPassengers 
        {
            get { return _numPassengers; }
            set { if (value < 0 || value > _capacity) throw new ArgumentException();
                _numPassengers = value;
            } 
        }

        public int Position { get; set; }
        public int Speed { get; init; }

        public virtual string Move()
        {
            Position += Speed;
            return "Moving along";
        }

        public virtual string Move(int times)
        {
            Position += Speed * times;
            return $"Moving along {times} times";
        }

        public Vehicle() 
        {
           
        }

        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            Speed = speed;
        }

        public override string ToString()
        {
            return  base.ToString() + $" capacity: {_capacity} passengers: {_numPassengers} speed: {Speed} position: {Position}";
            //return $"{_capacity}" ;
        }
    }
}
