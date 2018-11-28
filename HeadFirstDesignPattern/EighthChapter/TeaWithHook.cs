using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.EighthChapter
{
    class TeaWithHook : CaffeineBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
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
            Console.WriteLine("Would you like lemon with your tea (y/n)? ");
            return Console.ReadLine();
        }
    }
}
