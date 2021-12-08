using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class ModernSet : FurnitureFactory
    {
        public override Armchair CreateArmchair()
        {
            return new ModernArmchair();
        }

        public override Sofa CreateSofa()
        {
            return new ModernSofa();
        }

        public override Table CreateTable()
        {
            return new ModernTable();
        }

        public override string StyleFurniture()
        {
            return "Модерн";
        }
    }
}
