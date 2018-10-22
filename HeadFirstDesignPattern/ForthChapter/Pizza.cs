using System;
using System.Collections.Generic;

namespace HeadFirstDesignPattern.ForthChapter
{
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding topping: ");
            foreach (var item in toppings)
            {
                Console.WriteLine("    " + item);
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in offical PizzaStore box");
        }

        public virtual string GetName()
        {
            return name;
        }
    }
}
