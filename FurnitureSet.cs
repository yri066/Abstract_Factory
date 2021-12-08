using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class FurnitureSet
    {
        private string styleFurniture;
        private Armchair armchair;
        private Sofa sofa;
        private Table table;

        public FurnitureSet(FurnitureFactory furniture)
        {
            styleFurniture = furniture.StyleFurniture();
            armchair = furniture.CreateArmchair();
            sofa = furniture.CreateSofa();
            table = furniture.CreateTable();
        }

        public void Show()
        {
            Console.WriteLine($"Комплект мебели в стиле \"{styleFurniture}\" содержит следующие вещи:");
            armchair.StyleArmchair();
            sofa.StyleSofa();
            table.StyleTable();
        }
    }
}
