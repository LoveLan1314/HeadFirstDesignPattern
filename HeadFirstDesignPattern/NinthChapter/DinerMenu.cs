using System;
using System.Collections;

namespace HeadFirstDesignPattern.NinthChapter
{
    internal class DinerMenu : IMenu
    {
        private const int MAX_ITEMS = 6;
        private int numberOfItems = 0;
        private readonly MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];

            AddItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99M);

            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99M);

            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29M);

            AddItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05M);
        }

        public void AddItem(string name, string description, bool vegetarian, decimal price)
        {
            if (numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full! Can't add item to menu");
            }
            else
            {
                menuItems[numberOfItems++] = new MenuItem(name, description, vegetarian, price);
            }
        }

        //public MenuItem[] GetMenuItems()
        //{
        //    return menuItems;
        //}

        public IIterator CreateIterator()
        {
            return new DinerMenuIterator(menuItems);
        }
    }
}
