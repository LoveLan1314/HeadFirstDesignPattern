using System;

namespace HeadFirstDesignPattern.NinthChapter
{
    internal class MenuItem : MenuComponent
    {
        private readonly string _name;
        private readonly string _description;
        private readonly bool _vegetarian;
        private readonly decimal _price;

        public MenuItem(string name, string description, bool vegetarian, decimal price)
        {
            _name = name;
            _description = description;
            _vegetarian = vegetarian;
            _price = price;
        }

        public override string GetName()
        {
            return _name;
        }


        public override string GetDescription()
        {
            return _description;
        }


        public override bool IsVegetarian()
        {
            return _vegetarian;
        }


        public override decimal GetPrice()
        {
            return _price;
        }

        public override void Print()
        {
            Console.Write($"  {GetName()}");
            if (IsVegetarian())
            {
                Console.Write("(v)");
            }
            Console.WriteLine($", {GetPrice()}");
            Console.WriteLine($"    -- {GetDescription()}");
        }
    }
}
