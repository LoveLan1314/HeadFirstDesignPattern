using System;

namespace HeadFirstDesignPattern.TwelfthChapter
{
    internal class DuckCall : IQuackable
    {
        private readonly Observable _observable;

        public DuckCall()
        {
            _observable = new Observable(this);
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }

        public void Quack()
        {
            Console.WriteLine("Kwak");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }

        public override string ToString()
        {
            return "Duck Call";
        }
    }
}
