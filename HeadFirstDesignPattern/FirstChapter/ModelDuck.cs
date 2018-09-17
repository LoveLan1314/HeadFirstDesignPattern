using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.FirstChapter
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
