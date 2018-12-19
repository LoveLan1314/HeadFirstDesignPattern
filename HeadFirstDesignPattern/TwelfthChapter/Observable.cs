using System.Collections.Generic;

namespace HeadFirstDesignPattern.TwelfthChapter
{
    internal class Observable : IQuackObservable
    {
        private readonly IQuackObservable _duck;
        private readonly List<IObserver> _observers = new List<IObserver>();

        public Observable(IQuackObservable duck)
        {
            _duck = duck;
        }

        public void NotifyObservers()
        {
            foreach (var item in _observers)
            {
                item.Update(_duck);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
    }
}
