namespace HeadFirstDesignPattern.SixthChapter
{
    public class SimpleRemoteControl
    {
        private ICommand _solt;

        public SimpleRemoteControl()
        {

        }

        public void SetCommand(ICommand command)
        {
            _solt = command;
        }

        public void ButtonWasPressed()
        {
            _solt.Execute();
        }
    }

}