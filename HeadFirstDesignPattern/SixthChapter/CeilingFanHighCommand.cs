namespace HeadFirstDesignPattern.SixthChapter
{
    internal class CeilingFanHighCommand : CeilingFanTemplateCommand
    {
        public CeilingFanHighCommand(CeilingFan ceilingFan) : base(ceilingFan)
        {
        }

        public override void CeilingExecute()
        {
            ceilingFan.High();
        }
    }
}
