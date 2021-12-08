using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal abstract class FurnitureFactory
    {
        public abstract string StyleFurniture();
        public abstract Armchair CreateArmchair();
        public abstract Sofa CreateSofa();
        public abstract Table CreateTable();
    }
}
