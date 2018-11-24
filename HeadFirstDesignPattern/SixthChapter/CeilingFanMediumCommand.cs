using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.SixthChapter
{
    class CeilingFanMediumCommand : CeilingFanTemplateCommand
    {
        public CeilingFanMediumCommand(CeilingFan ceilingFan) : base(ceilingFan)
        {
        }

        public override void CeilingExecute()
        {
            ceilingFan.Medium();
        }
        
    }
}
