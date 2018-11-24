namespace HeadFirstDesignPattern.SixthChapter
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}