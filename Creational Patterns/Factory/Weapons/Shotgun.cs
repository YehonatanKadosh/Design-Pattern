using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Weapons
{
    class Shotgun : IWeapon
    {
        public void Hit() => Console.WriteLine("Strike by shotgun!");
    }
}
