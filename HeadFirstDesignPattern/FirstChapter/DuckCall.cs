using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.FirstChapter
{
    public class DuckCall
    {
        private readonly IQuackBehavior _quackBehavior;
        public DuckCall()
        {
            _quackBehavior = new Quack();
        }

        public void PerformQuack()
        {
            _quackBehavior.Quack();
        }
    }
}
