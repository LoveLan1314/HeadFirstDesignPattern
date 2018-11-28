using System;

namespace HeadFirstDesignPattern.EighthChapter
{
    internal class CoffeeWithHook : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        protected override bool CustomerWantsCondiments()
        {
            string answer = GetUserInput();
            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GetUserInput()
        {
            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)? ");
            return Console.ReadLine();
        }
    }
}
