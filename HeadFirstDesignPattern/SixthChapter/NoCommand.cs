namespace HeadFirstDesignPattern.SixthChapter
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            
        }

        public void Undo()
        {
            throw new System.NotImplementedException();
        }
    }
}