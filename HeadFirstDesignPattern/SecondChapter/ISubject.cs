namespace HeadFirstDesignPattern.SecondChapter
{
    internal interface ISubject
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObserver();
    }
}
