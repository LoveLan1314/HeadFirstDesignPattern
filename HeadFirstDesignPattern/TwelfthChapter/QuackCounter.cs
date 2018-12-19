namespace HeadFirstDesignPattern.TwelfthChapter
{
    internal class QuackCounter : IQuackable
    {
        private readonly IQuackable _duck;

        public QuackCounter(IQuackable duck)
        {
            _duck = duck;
        }

        public static int NumberOfQuacks { get; private set; }

        public void NotifyObservers()
        {
            _duck.NotifyObservers();
        }

        public void Quack()
        {
            _duck.Quack();
            NumberOfQuacks++;
        }

        public void RegisterObserver(IObserver observer)
        {
            _duck.RegisterObserver(observer);
        }
    }
}
