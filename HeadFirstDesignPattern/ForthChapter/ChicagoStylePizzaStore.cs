using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.ForthChapter
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if(type == "cheese")
            {
                return new ChicagoStyleCheesePizza();
            }
            else if(type == "pepperoni")
            {
                return new ChicagoStylePepperoniPizza();
            }
            else if(type == "clam")
            {
                return new ChicagoStyleClamPizza();
            }
            else if(type == "veggie")
            {
                return new ChicagoStyleVeggiePizza();
            }
            throw new ArgumentException("type类别错误");
        }
    }
}
