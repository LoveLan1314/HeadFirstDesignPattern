namespace HeadFirstDesignPattern.SecondChapter
{
    internal interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}
