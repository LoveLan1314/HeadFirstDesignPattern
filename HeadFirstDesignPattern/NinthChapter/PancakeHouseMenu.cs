using System.Collections;

namespace HeadFirstDesignPattern.NinthChapter
{
    internal class PancakeHouseMenu : IMenu
    {
        private readonly ArrayList _menuItems;
        public PancakeHouseMenu()
        {
            _menuItems = new ArrayList();
            AddItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99M);

            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99M);

            AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49M);

            AddItem("Waffles", "Waffles, with our choice of blueberries or strawberries", true, 3.59M);
        }

        private void AddItem(string name, string description, bool vegetarian, decimal price)
        {
            _menuItems.Add(new MenuItem(name, description, vegetarian, price));
        }

        //public ArrayList GetMenuItems()
        //{
        //    return menuItems;
        //}

        public IIterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(_menuItems);
        }
    }
}
