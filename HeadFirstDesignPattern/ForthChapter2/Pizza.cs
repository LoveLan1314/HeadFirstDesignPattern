using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.ForthChapter2
{
    public abstract class Pizza
    {
        protected string name;
        protected IDough dough;
        protected ISauce sauce;
        protected IVeggies[] veggies;
        protected ICheese cheese;
        protected IPepperoni pepperoni;
        protected IClams clams;
        protected List<string> toppings = new List<string>();

        public abstract void Prepare();

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

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
