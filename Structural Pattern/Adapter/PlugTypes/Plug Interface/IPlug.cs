using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.PlugTypes.Plug_Interface
{
    public interface IPlug
    {
        int Voltage { get; }
        string Name { get; }
    }
}
