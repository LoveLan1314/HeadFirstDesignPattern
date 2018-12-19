namespace HeadFirstDesignPattern.TwelfthChapter
{
    internal interface IQuackObservable
    {
        void RegisterObserver(IObserver observer);
        //这个地方正常情况下不应该有这个方法，这个位置这么处理是由于使用了装饰者和组合模式，需要将该方法暴露
        void NotifyObservers();
    }
}
