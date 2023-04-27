using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Camera : IShootable
    {
        private string _brand;

        public Camera (string brand)
        {
            this._brand = brand;
        }

        public string Shoot()
        {
            return $"Shooting a {base.GetType()} " +
                   $"- {_brand}";
        }


        public override string ToString()
        {
            return $"{base.ToString()}";
        }

    }
}