using Adapter.PlugTypes.Plug_Interface;

namespace Adapter.PlugTypes
{
    public class EU_Plug : IPlug
    {
        public EU_Plug()
        {
            System.Console.WriteLine("European Plug Created");

        }
        public int Voltage => 220;

        public string Name => "European Plug";
    }
}
