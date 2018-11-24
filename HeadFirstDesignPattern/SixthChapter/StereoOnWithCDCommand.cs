using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.SixthChapter
{
    class StereoOnWithCDCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
            _stereo.SetCD();
            _stereo.SetVolume(11);
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
