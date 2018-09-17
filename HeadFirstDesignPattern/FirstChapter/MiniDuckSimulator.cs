using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.FirstChapter
{
    public class MiniDuckSimulator
    {
        public static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }
    }
}
