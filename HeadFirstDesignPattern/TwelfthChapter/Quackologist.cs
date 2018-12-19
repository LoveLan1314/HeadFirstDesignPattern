using System;

namespace HeadFirstDesignPattern.TwelfthChapter
{
    internal class Quackologist : IObserver
    {
        public void Update(IQuackObservable duck)
        {
            Console.WriteLine($"Quackologist: {duck} just quacked.");
        }
    }
}
