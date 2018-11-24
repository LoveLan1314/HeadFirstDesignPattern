using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.SixthChapter
{
    class CeilingFanOnCommand : ICommand
    {
        private readonly CeilingFan ceilingFan;

        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            ceilingFan.On();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
