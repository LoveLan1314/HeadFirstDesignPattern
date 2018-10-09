using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.ThirdChapter
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast Coffee";
        }

        public override double Cost()
        {
            return 1.49;
        }
    }
}
