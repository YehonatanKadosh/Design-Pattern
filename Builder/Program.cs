using Builder.Doors;
using Builder.Roofs;
using Builder.Walls;
using Builder.Windows;
using System.Collections.Generic;
using System.Linq;

namespace Builder
{
    class Program
    {
        /// <summary>
        /// using Builder Pattern to build a house by demand
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Example 1 for a Builder using HouseBuilder
            House Home = new House();
            Home.AddWall(new BrickWall())
                .AddDoor(new SteelDoor())
                .AddRoof(new ColoredRoof())
                .AddWindow(new StylishWindow()); // Building the House as i see fit
            //returns the new House

            //Example 2 for a Builder using linq
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            numbers.Where(n => n > 2)
                   .Where(n => n < 9)
                   .OrderBy(n => n)
                   .Skip(2)
                   .Take(3)
                   .ToList();// Bulding the list as i see fit
            //returns the new List<int>
        }
    }
}
