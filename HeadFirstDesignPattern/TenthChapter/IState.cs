namespace HeadFirstDesignPattern.TenthChapter
{
    internal interface IState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrand();
        void Dispense();
    }
}
