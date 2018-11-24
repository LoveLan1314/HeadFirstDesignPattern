using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.SixthChapter
{
    internal class CeilingFanOffCommand : CeilingFanTemplateCommand
    {
        public CeilingFanOffCommand(CeilingFan ceilingFan) : base(ceilingFan)
        {
        }

        public override void CeilingExecute()
        {
            ceilingFan.Off();
        }
    }
}
