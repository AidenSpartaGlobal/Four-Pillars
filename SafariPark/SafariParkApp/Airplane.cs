using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Airplane : Vehicle
    {
        public int Altitude { get; private set; } = 0;
        private string _airline;

        public Airplane(int capacity) : base(capacity)
        {

        }

        public Airplane(int capacity, int speed, string airline) : base(capacity, speed)
        {
            Speed = speed; 
            _airline = airline;
        }

        public void Ascend(int distance)
        {
            this.Altitude += distance;
        }

        public void Descend(int distance)
        {
            this.Altitude -= distance;
        }

        public override string Move()
        {
            return $"{base.Move()} at an altitude of {Altitude}";
        }

        public override string Move(int times)
        {   
            return $"{base.Move(times)} at an altitude of {Altitude}";
        }

        public override string ToString()
        {
            return $"Thank you for flying {_airline}:{base.ToString()} Altitude: {Altitude}.";
        }
    }
}
