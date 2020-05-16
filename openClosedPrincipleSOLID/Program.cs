using System;

namespace openClosedPrincipleSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            var khurshed = new Cook("Khurshed");
            khurshed.MakeDinner(new PotatoMeal());
        }
    }

    interface IMeal
    {
        void Make();
    }

    class PotatoMeal : IMeal
    {
        public void Make()
        {
            Console.WriteLine("Чистим картошку");
            Console.WriteLine("Ставим почищенную картошку на огонь");
            Console.WriteLine("Сливаем остатки воды, разминаем варенный картофель в пюре");
            Console.WriteLine("Посыпаем пюре специями и зеленью");
            Console.WriteLine("Картофель пюре готов!");
        }
    }

    class Cook
    {
        public string Name { get; set; }

        public Cook(string Name)
        {
            this.Name = Name;
        }
        public void MakeDinner(IMeal meal)
        {
            meal.Make();
        }
    }
}
