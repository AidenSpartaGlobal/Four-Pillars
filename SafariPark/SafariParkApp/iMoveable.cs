using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    internal interface iMoveable
    {

        public int Position { get; set; }
        public int Speed { get; init; }


        string Move();
        string Move(int times);

    }
}
