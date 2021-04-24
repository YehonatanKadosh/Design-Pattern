using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Movments
{
    class Swimming : IMovement
    {
        public void Move() => Console.WriteLine("Swimming");
    }
}
