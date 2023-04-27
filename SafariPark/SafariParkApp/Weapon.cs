using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public abstract class Weapon : IShootable
    {
        private string _brand;

        public Weapon(string brand)
        {
            this._brand = brand;
        }

        public virtual string Shoot()
        {
            return $"{this.GetType()}";
        }

        public override string ToString()
        {
            return $"Shooting a {base.ToString()} - {_brand}";
        }



    }
}