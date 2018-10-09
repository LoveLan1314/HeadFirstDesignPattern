using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.ThirdChapter
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string GetDescription();
    }
}
