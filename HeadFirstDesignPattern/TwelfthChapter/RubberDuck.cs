using System;

namespace HeadFirstDesignPattern.TwelfthChapter
{
    internal class RubberDuck : IQuackable
    {
        private readonly Observable _observable;

        public RubberDuck()
        {
            _observable = new Observable(this);
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }

        public void Quack()
        {
            Console.WriteLine("Squeak");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }

        public override string ToString()
        {
            return "Rubber Duck";
        }
    }
}
