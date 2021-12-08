using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class VictorianSet : FurnitureFactory
    {
        public override Armchair CreateArmchair()
        {
            return new VictorianArmchair();
        }

        public override Sofa CreateSofa()
        {
            return new VictorianSofa();
        }

        public override Table CreateTable()
        {
            return new VictorianTable();
        }

        public override string StyleFurniture()
        {
            return "Викторианский";
        }
    }
}
