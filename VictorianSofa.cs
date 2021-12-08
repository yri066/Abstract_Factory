using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class VictorianSofa : Sofa
    {
        public override void StyleSofa()
        {
            Console.WriteLine("диван в викторианском стиле");
        }
    }
}
