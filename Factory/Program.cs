using Factory.Heros;

namespace Factory
{
    /// <summary>
    /// Easy to keep track and create more types of
    /// Weapons, Heros and movements by using interfaces and abstract methods
    /// this is the Factory - Design Pattern
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Hero Elf = new Hero(new Elf());
            Elf.Move();
            Elf.Hit();

            Hero Archer = new Hero(new Archer());
            Archer.Move();
            Archer.Hit();

            Hero FisherMan = new Hero(new Fisherman());
            FisherMan.Move();
            FisherMan.Hit();
        }
    }
}
