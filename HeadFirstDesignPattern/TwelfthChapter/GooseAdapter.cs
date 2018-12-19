namespace HeadFirstDesignPattern.TwelfthChapter
{
    internal class GooseAdapter : IQuackable
    {
        private readonly Goose _goose;
        private readonly Observable _observable;

        public GooseAdapter(Goose goose)
        {
            _goose = goose;
            _observable = new Observable(this);
        }
        
        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }


        public void Quack()
        {
            _goose.Honk();
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }

        public override string ToString()
        {
            return "Goose pretending to be a Duck";
        }
    }
}
