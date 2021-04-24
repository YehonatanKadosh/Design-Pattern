using System;

namespace Factory
{
    public abstract class HeroFactory
    {
        public HeroFactory() => Console.WriteLine("Hero's Ready!");
        public abstract IMovement CreateMovement();
        public abstract IWeapon CreateWeapon();
    }
}