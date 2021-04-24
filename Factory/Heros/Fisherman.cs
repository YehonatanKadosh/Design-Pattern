using Factory.Movments;
using Factory.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Heros
{
    class Fisherman : HeroFactory
    {
        public override IMovement CreateMovement() => new Swimming();
        public override IWeapon CreateWeapon() => new Axe();
    }
}
