namespace HeadFirstDesignPattern.NinthChapter
{
    //internal class Waitress
    //{
    //    private readonly IMenu _pancakeHouseMenu;
    //    private readonly IMenu _dinerMenu;
    //    private readonly IMenu _cafeMenu;

    //    public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu, IMenu cafeMenu)
    //    {
    //        _pancakeHouseMenu = pancakeHouseMenu;
    //        _dinerMenu = dinerMenu;
    //        _cafeMenu = cafeMenu;
    //    }

    //    public void PrintMenu()
    //    {
    //        IIterator pancakeIterator = _pancakeHouseMenu.CreateIterator();
    //        IIterator dinerIterator = _dinerMenu.CreateIterator();
    //        IIterator cafeIterator = _cafeMenu.CreateIterator();
    //        Console.WriteLine("MENU\n----\nBREAKFAST");
    //        PrintMenu(pancakeIterator);
    //        Console.WriteLine("\nLUNCH");
    //        PrintMenu(dinerIterator);
    //        Console.WriteLine("\nDINNER");
    //        PrintMenu(cafeIterator);
    //    }

    //    private void PrintMenu(IIterator iterator)
    //    {
    //        while (iterator.HasNext())
    //        {
    //            MenuItem menuItem = (MenuItem)iterator.Next();
    //            Console.Write($"{menuItem.GetName()}, ");
    //            Console.Write($"{menuItem.GetPrice()} -- ");
    //            Console.WriteLine($"{menuItem.GetDescription()}");
    //        }
    //    }
    //}

    internal class Waitress
    {
        private readonly MenuComponent _allMenus;

        public Waitress(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        public void PrintMenu()
        {
            _allMenus.Print();
        }
    }
}
