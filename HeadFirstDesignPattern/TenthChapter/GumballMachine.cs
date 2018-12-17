using System;

namespace HeadFirstDesignPattern.TenthChapter
{
    //internal class GumballMachine
    //{
    //    private const int SoldOut = 0;
    //    private const int NoQuarter = 1;
    //    private const int HasQuarter = 2;
    //    private const int Sold = 3;

    //    private int _state = SoldOut;
    //    private int _count = 0;

    //    public GumballMachine(int count)
    //    {
    //        _count = count;
    //        if (count > 0)
    //        {
    //            _state = NoQuarter;
    //        }
    //    }

    //    public void InsertQuarter()
    //    {
    //        if (_state == HasQuarter)
    //        {
    //            Console.WriteLine("You can't insert another quarter");
    //        }
    //        else if (_state == NoQuarter)
    //        {
    //            _state = HasQuarter;
    //            Console.WriteLine("You inserted a quarter");
    //        }
    //        else if (_state == SoldOut)
    //        {
    //            Console.WriteLine("You can't insert a quarter, the machine is sold out");
    //        }
    //        else if (_state == Sold)
    //        {
    //            Console.WriteLine("Please wait, we're already giving you a gumball");
    //        }
    //    }

    //    public void EjectQuarter()
    //    {
    //        if (_state == HasQuarter)
    //        {
    //            Console.WriteLine("Quarter returned");
    //            _state = NoQuarter;
    //        }
    //        else if (_state == NoQuarter)
    //        {
    //            Console.WriteLine("You haven't inserted a quarter");
    //        }
    //        else if (_state == Sold)
    //        {
    //            Console.WriteLine("Sorry, your already turned the crank");
    //        }
    //        else if (_state == SoldOut)
    //        {
    //            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
    //        }
    //    }

    //    public void TurnCrank()
    //    {
    //        if (_state == Sold)
    //        {
    //            Console.WriteLine("Turning twice doesn't get you another gunball");
    //        }
    //        else if (_state == NoQuarter)
    //        {
    //            Console.WriteLine("You turned but there's no quarter");
    //        }
    //        else if (_state == SoldOut)
    //        {
    //            Console.WriteLine("You truned, but there are no gumballs");
    //        }
    //        else if (_state == HasQuarter)
    //        {
    //            Console.WriteLine("You turned...");
    //            _state = Sold;
    //            Dispense();
    //        }
    //    }

    //    private void Dispense()
    //    {
    //        if (_state == Sold)
    //        {
    //            Console.WriteLine("A gumball comes rolling out the slot");
    //            _count = _count - 1;
    //            if (_count == 0)
    //            {
    //                Console.WriteLine("Oops, out of gumballs!");
    //                _state = SoldOut;
    //            }
    //            else
    //            {
    //                _state = NoQuarter;
    //            }
    //        }
    //        else if (_state == NoQuarter)
    //        {
    //            Console.WriteLine("You need to pay first");
    //        }
    //        else if (_state == SoldOut)
    //        {
    //            Console.WriteLine("No gumball dispensed");
    //        }
    //        else if (_state == HasQuarter)
    //        {
    //            Console.WriteLine("No gumball dispensed");
    //        }
    //    }

    //    public override string ToString()
    //    {
    //        StringBuilder sb = new StringBuilder();
    //        sb.AppendLine();
    //        sb.AppendLine("Mighty Gumball, Inc.");
    //        sb.AppendLine("Java-enabled Standing Gumball Model #2004");
    //        sb.AppendLine($"Inventory: {_count} gumballs");
    //        if(_state == SoldOut)
    //        {
    //            sb.AppendLine("Machine is sold out");
    //        }
    //        else
    //        {
    //            sb.AppendLine("Machine is wating for quarter");
    //        }
    //        return sb.ToString();
    //    }
    //}

    internal class GumballMachine
    {
        public IState SoldOutState { get; }
        public IState NoQuarterState { get; }
        public IState HasQuarterState { get; }
        public IState SoldState { get; }
        public IState WinnerState { get; }

        public IState State { get; private set; }
        public int Count { get; private set; }
        public string Location { get; }

        public GumballMachine(int numberGumballs)
        {
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            WinnerState = new WinnerState(this);
            Count = numberGumballs;
            if (numberGumballs > 0)
            {
                State = NoQuarterState;
            }
        }

        public GumballMachine(string location, int count) : this(count)
        {
            Location = location;
        }

        public void InsertQuarter()
        {
            State.InsertQuarter();
        }

        public void EjectQuarter()
        {
            State.EjectQuarter();
        }

        public void TurnCrank()
        {
            State.TurnCrand();
            State.Dispense();
        }

        public void SetState(IState state)
        {
            State = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (Count != 0)
            {
                Count = Count - 1;
            }
        }
    }
}
