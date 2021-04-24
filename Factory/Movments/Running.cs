using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Movments
{
    class Running : IMovement
    {
        public void Move()
        {
            Console.WriteLine("Running!");
        }
    }
}
