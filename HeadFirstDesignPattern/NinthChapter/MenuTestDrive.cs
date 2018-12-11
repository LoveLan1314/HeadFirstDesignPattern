namespace HeadFirstDesignPattern.NinthChapter
{
    public class MenuTestDrive
    {
        //public static void Main(string[] args)
        //{
        //    PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
        //    DinerMenu dinerMenu = new DinerMenu();
        //    CafeMenu cafeMenu = new CafeMenu();

        //    Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu, cafeMenu);

        //    waitress.PrintMenu();
        //}

        public static void Main(string[] args)
        {
            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfase");
            MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
            MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");

            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");

            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            dinerMenu.Add(new MenuItem("Pasta", "Spaghetti with Marinara Sauce, and a slice of sourdough bread", true, 3.89M));

            dinerMenu.Add(dessertMenu);

            dessertMenu.Add(new MenuItem("Apple Pie", "Apple Pie with a flakey crust, topped with vanilla ice cream", true, 1.59M));

            Waitress waitress = new Waitress(allMenus);

            waitress.PrintMenu();
        }
    }
}
