using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class EmpireTable : Table
    {
        public override void StyleTable()
        {
            Console.WriteLine("стол в стиле ампир");
        }
    }
}
