using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.TwelfthChapter
{
    abstract class AbstractDuckFactory
    {
        public abstract IQuackable CreateMallardDuck();
        public abstract IQuackable CreateRedheadDuck();
        public abstract IQuackable CreateDuckCall();
        public abstract IQuackable CreateRubberDuck();
    }
}
