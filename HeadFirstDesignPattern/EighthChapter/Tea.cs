using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.EighthChapter
{
    class Tea : CaffeineBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }
    }
}
