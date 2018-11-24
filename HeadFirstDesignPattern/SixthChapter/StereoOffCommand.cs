using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.SixthChapter
{
    class StereoOffCommand : ICommand
    {
        private readonly Stereo stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.Off();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
