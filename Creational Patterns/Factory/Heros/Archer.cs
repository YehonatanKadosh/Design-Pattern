using Factory.Movments;
using Factory.Weapons;
using System;

namespace Factory.Heros
{
    class Archer : HeroFactory
    {

        public override IMovement CreateMovement() => new Running();
        public override IWeapon CreateWeapon() => new Bow_Arrow();
    }
}
