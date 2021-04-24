using Builder.Doors.Doors_Interface;
using Builder.Roofs.Roofs_Interface;
using Builder.Walls.Walls_Interface;
using Builder.Windows.Windows_Interface;
using System;

namespace Builder
{
    public static class HouseBuilder
    {
        public static House AddWall(this House house, IWall wall)
        {
            Console.WriteLine($"Adding {wall.Name} To the House");
            return house;
        }
        public static House AddWindow(this House house, IWindow window)
        {
            Console.WriteLine($"Adding {window.Name} To the House");
            return house;
        }
        public static House AddDoor(this House house, IDoor door)
        {
            Console.WriteLine($"Adding {door.Name} To the House");
            return house;
        }
        public static House AddRoof(this House house, IRoof roof)
        {
            Console.WriteLine($"Adding {roof.Name} To the House");
            return house;
        }
    }
    public class House { }
}
