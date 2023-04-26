using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Vehicle
    {
        private int _capacity;
        private int _numPassengers;

        public int NumPassengers {
            get { return _numPassengers; }
            set { if (value < 0 && value > _capacity) throw new ArgumentException(); } }

        public int Position { get; set; }
        public int Speed { get; init; } = 10;

        public string Move()
        {
            Position = Speed * 1;
            return "Moving along";
        }

        public string Move(int x)
        {
            Position = Speed * x;
            return $"Moving along {x} times";
        }

        public Vehicle() 
        { 

        }

        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            Speed = speed;
        }
    }
}
