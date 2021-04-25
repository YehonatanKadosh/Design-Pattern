using Adapter.PlugTypes.Plug_Interface;

namespace Adapter.PlugTypes
{
    public class UK_Plug : IPlug
    {
        public UK_Plug()
        {
            System.Console.WriteLine("United Kingdom's Plug Created");
        }
        public int Voltage => 220;

        public string Name => "United Kingdom's Plug";
    }
}
