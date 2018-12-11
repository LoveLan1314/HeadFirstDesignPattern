using System;
using System.Collections;

namespace HeadFirstDesignPattern.NinthChapter
{
    internal class Menu : MenuComponent
    {
        private readonly ArrayList _menuComponents = new ArrayList();
        private readonly string _name;
        private readonly string _description;

        public Menu(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return (MenuComponent)_menuComponents[i];
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override void Print()
        {
            Console.Write($"\n{GetName()}");
            Console.WriteLine($", {GetDescription()}");
            Console.WriteLine("---------------------");

            foreach (MenuComponent item in _menuComponents)
            {
                item.Print();
            }
        }
    }
}
