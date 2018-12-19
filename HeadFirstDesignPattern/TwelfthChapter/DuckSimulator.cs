using System;

namespace HeadFirstDesignPattern.TwelfthChapter
{
    //internal class DuckSimulator
    //{
    //    public static void Main(string[] args)
    //    {
    //        DuckSimulator simulator = new DuckSimulator();
    //        simulator.Simulate();
    //    }

    //    private void Simulate()
    //    {
    //        IQuackable mallardDuck = new QuackCounter(new MallardDuck());
    //        IQuackable redheadDuck = new QuackCounter(new RedheadDuck());
    //        IQuackable duckCall = new QuackCounter(new DuckCall());
    //        IQuackable rubberDuck = new QuackCounter(new RubberDuck());
    //        IQuackable gooseDuck = new GooseAdapter(new Goose());

    //        Console.WriteLine("\nDuck Simulator");

    //        Simulate(mallardDuck);
    //        Simulate(redheadDuck);
    //        Simulate(duckCall);
    //        Simulate(rubberDuck);
    //        Simulate(gooseDuck);

    //        Console.WriteLine($"The ducks quacked {QuackCounter.NumberOfQuacks} times");
    //    }

    //    private void Simulate(IQuackable duck)
    //    {
    //        duck.Quack();
    //    }
    //}

    internal class DuckSimulator
    {
        public static void Main(string[] args)
        {
            DuckSimulator simulator = new DuckSimulator();
            AbstractDuckFactory duckFactory = new CountingDuckFactory();

            simulator.Simulate(duckFactory);
        }

        //private void Simulate(AbstractDuckFactory duckFactory)
        //{
        //    IQuackable mallardDuck = duckFactory.CreateMallardDuck();
        //    IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
        //    IQuackable duckCall = duckFactory.CreateDuckCall();
        //    IQuackable rubberDuck = duckFactory.CreateRubberDuck();
        //    IQuackable gooseDuck = new GooseAdapter(new Goose());

        //    Console.WriteLine("\nDuck Simulator: With Abstract Factory");

        //    Simulate(mallardDuck);
        //    Simulate(redheadDuck);
        //    Simulate(duckCall);
        //    Simulate(rubberDuck);
        //    Simulate(gooseDuck);

        //    Console.WriteLine($"The ducks quacked {QuackCounter.NumberOfQuacks} times");
        //}

        private void Simulate(AbstractDuckFactory duckFactory)
        {
            IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();
            IQuackable gooseDuck = new GooseAdapter(new Goose());
            Console.WriteLine("\nDuck Sumulator: With Composite - Flocks");

            Flock flockOfDucks = new Flock();

            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(gooseDuck);

            Flock flockOfMallards = new Flock();

            IQuackable mallardOne = duckFactory.CreateMallardDuck();
            IQuackable mallardTwo = duckFactory.CreateMallardDuck();
            IQuackable mallardThree = duckFactory.CreateMallardDuck();
            IQuackable mallardFour = duckFactory.CreateMallardDuck();

            flockOfMallards.Add(mallardOne);
            flockOfMallards.Add(mallardTwo);
            flockOfMallards.Add(mallardThree);
            flockOfMallards.Add(mallardFour);

            flockOfDucks.Add(flockOfMallards);

            //Console.WriteLine("\nDuck Simulator: Whole Flock Simulation");
            //Simulate(flockOfDucks);

            //Console.WriteLine("\nDuck Simulator: Mallard Flock Simulation");
            //Simulate(flockOfMallards);

            Quackologist quackologist = new Quackologist();
            flockOfDucks.RegisterObserver(quackologist);

            Simulate(flockOfDucks);

            Console.WriteLine($"The ducks quacked {QuackCounter.NumberOfQuacks} times");
        }

        private void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
