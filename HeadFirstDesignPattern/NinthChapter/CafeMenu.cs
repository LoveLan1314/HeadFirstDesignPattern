using System.Collections;

namespace HeadFirstDesignPattern.NinthChapter
{
    internal class CafeMenu : IMenu
    {
        private readonly Hashtable _menuItems = new Hashtable();

        public CafeMenu()
        {
            AddItem("Veggie Burger and Air Fries", "Veggie burger on a whole wheat bun, letture, tomato, and fries", true, 3.99M);
            AddItem("Soup of the day", "A cup of the soup of the day, with a side salad", false, 3.69M);
            AddItem("Burrito", "A large burrito, with thole pinto beans, salsa, guacamole", true, 4.29M);
        }

        public void AddItem(string name, string description, bool vegetarian, decimal price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            _menuItems.Add(menuItem.GetName(), menuItem);
        }

        public IIterator CreateIterator()
        {
            return new CafeMenuIterator(_menuItems);
        }

        //public Hashtable GetItems()
        //{
        //    return _menuItems;
        //}
    }
}
