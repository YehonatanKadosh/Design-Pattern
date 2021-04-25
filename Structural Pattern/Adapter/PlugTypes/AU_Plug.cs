using Adapter.PlugTypes.Plug_Interface;

namespace Adapter.PlugTypes
{
    public class AU_Plug : IPlug
    {
        public AU_Plug()
        {
            System.Console.WriteLine("Australian Plug Created");

        }
        public int Voltage => 220;

        public string Name => "Australian Plug";
    }
}
