using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.EighthChapter
{
    abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        protected abstract void Brew();

        protected abstract void AddCondiments();

        private void BoilWater()
        {
            Console.WriteLine("Boiling Water");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        protected virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}
