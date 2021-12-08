using System;

namespace Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тестовый случай 1: Ампир");
            GetSet("Ампир");
            Console.WriteLine("Тестовый случай 2: Модерн");
            GetSet("Модерн");
            Console.WriteLine("Тестовый случай 3: Викторианский");
            GetSet("Викторианский");
            Console.WriteLine("Тестовый случай 4: Хай-тек");
            GetSet("Хай-тек");
        }

        static void GetSet(string set)
        {
            FurnitureSet furniture;

            if (set == "Викторианский")
            {
                furniture = new FurnitureSet(new VictorianSet());
                furniture.Show();
            }
            else if (set == "Ампир")
            {
                furniture = new FurnitureSet(new EmpireSet());
                furniture.Show();
            }
            else if (set == "Модерн")
            {
                furniture = new FurnitureSet(new ModernSet());
                furniture.Show();
            }
            else
                Console.WriteLine($"Комплект мебели {set} отсутствует.");

            Console.WriteLine("");
        }
    }
}
