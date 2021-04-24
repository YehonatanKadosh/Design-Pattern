namespace Factory
{
    public class Hero
    {
        private readonly IMovement Movement;
        private readonly IWeapon Weapon;

        public Hero(HeroFactory Hero_Type)
        {
            Movement = Hero_Type.CreateMovement();
            Weapon = Hero_Type.CreateWeapon();
        }

        public void Move() => this.Movement.Move();
        public void Hit() => this.Weapon.Hit();
    }
}