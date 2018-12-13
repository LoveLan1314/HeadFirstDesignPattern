using System;

namespace HeadFirstDesignPattern.TenthChapter
{
    internal class HasQuarterState : IState
    {
        private Random randomWinner = new Random();
        private readonly GumballMachine _gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _gumballMachine.SetState(_gumballMachine.NoQuarterState);
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void TurnCrand()
        {
            Console.WriteLine("You turned...");
            int winner = randomWinner.Next(10);
            if (winner == 0 && _gumballMachine.Count > 1)
            {
                _gumballMachine.SetState(_gumballMachine.WinnerState);
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.SoldState);
            }
        }
    }
}
