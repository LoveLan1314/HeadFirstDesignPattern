using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.SixthChapter
{
    class CeilingFanLowCommand : CeilingFanTemplateCommand
    {
        public CeilingFanLowCommand(CeilingFan ceilingFan) : base(ceilingFan)
        {
        }

        public override void CeilingExecute()
        {
            ceilingFan.Low();
        }
    }
}
