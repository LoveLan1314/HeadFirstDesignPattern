using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.EighthChapter
{
    class Coffee : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }
    }
}
