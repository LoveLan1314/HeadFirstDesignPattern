using HeadFirstDesignPattern.TenthChapter;
using System;

namespace HeadFirstDesignPattern.EvelethChapter
{
    internal class GumballMonitor
    {
        private readonly GumballMachine _machine;

        public GumballMonitor(GumballMachine machine)
        {
            _machine = machine;
        }

        public void Report()
        {
            Console.WriteLine($"Gumball Machine: {_machine.Location}");
            Console.WriteLine($"Cureent inventroy: {_machine.Count} gumballs");
            Console.WriteLine($"Current state: {_machine.State}");
        }
    }
}
