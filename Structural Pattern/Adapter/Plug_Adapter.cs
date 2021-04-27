using Adapter.PlugTypes;
using Adapter.PlugTypes.Plug_Interface;

namespace Adapter
{
    public static class Plug_Adapter_Extention
    {
        public static EU_Plug Adapt_To_EU(this IPlug plug)
        {
            System.Console.WriteLine($"Inserting the {plug.Name} in the EU Adapter");
            return new EU_Plug();
        }
        public static ES_Plug Adapt_To_ES(this IPlug plug)
        {
            System.Console.WriteLine($"Inserting the {plug.Name} in the ES Adapter");
            return new ES_Plug();
        }
        public static UK_Plug Adapt_To_UK(this IPlug plug)
        {
            System.Console.WriteLine($"Inserting the {plug.Name} in the UK Adapter");
            return new UK_Plug();
        }
        public static AU_Plug Adapt_To_AU(this IPlug plug)
        {
            System.Console.WriteLine($"Inserting the {plug.Name} in the AU Adapter");
            return new AU_Plug();
        }
    }
}
