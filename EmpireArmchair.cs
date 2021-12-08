using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class EmpireArmchair : Armchair
    {
        public override void StyleArmchair()
        {
            Console.WriteLine("кресло в стиле ампир");
        }
    }
}
