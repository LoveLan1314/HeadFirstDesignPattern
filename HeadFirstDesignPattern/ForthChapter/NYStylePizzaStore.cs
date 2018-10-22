using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.ForthChapter
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if(type == "cheese")
            {
                return new NYStyleCheesePizza();
            }
            else if(type == "pepperoni")
            {
                return new NYStylePepperoniPizza();
            }
            else if(type == "clam")
            {
                return new NYStyleClamPizza();
            }
            else if(type == "veggie")
            {
                return new NYStyleVeggiePizza();
            }
            throw new ArgumentException("type类别错误");
        }
    }
}
