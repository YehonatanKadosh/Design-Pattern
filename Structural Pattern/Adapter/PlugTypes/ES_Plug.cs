using Adapter.PlugTypes.Plug_Interface;

namespace Adapter.PlugTypes
{
    public class ES_Plug : IPlug
    {
        public ES_Plug()
        {
            System.Console.WriteLine("Spanish Plug Created");
        }
        public int Voltage => 220;

        public string Name => "Spanish plug";
    }
}
