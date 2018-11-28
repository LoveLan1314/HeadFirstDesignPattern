using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.EighthChapter
{
    class BeverageTestDrive
    {
        public static void Main(string[] args)
        {
            TeaWithHook teaHook = new TeaWithHook();
            CoffeeWithHook coffeeHook = new CoffeeWithHook();

            Console.WriteLine("\nMaking tea...");
            teaHook.PrepareRecipe();

            Console.WriteLine("\nMaking coffee...");
            coffeeHook.PrepareRecipe();
        }
    }
}
