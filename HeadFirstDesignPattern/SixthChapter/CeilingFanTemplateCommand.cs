using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.SixthChapter
{
    abstract class CeilingFanTemplateCommand : ICommand
    {
        protected readonly CeilingFan ceilingFan;
        private int prevSpeed;

        protected CeilingFanTemplateCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.GetSpeed();
            CeilingExecute();
        }

        public abstract void CeilingExecute();

        public void Undo()
        {
            if (prevSpeed == CeilingFan.HIGH)
            {
                ceilingFan.High();
            }
            if (prevSpeed == CeilingFan.MEDIUM)
            {
                ceilingFan.Medium();
            }
            if (prevSpeed == CeilingFan.LOW)
            {
                ceilingFan.Low();
            }
            if (prevSpeed == CeilingFan.OFF)
            {
                ceilingFan.Off();
            }
        }
    }
}
