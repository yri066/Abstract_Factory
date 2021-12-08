using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class EmpireSet : FurnitureFactory
    {
        public override Armchair CreateArmchair()
        {
            return new EmpireArmchair();
        }

        public override Sofa CreateSofa()
        {
            return new EmpireSofa();
        }

        public override Table CreateTable()
        {
            return new EmpireTable();
        }

        public override string StyleFurniture()
        {
            return "Ампир";
        }
    }
}
