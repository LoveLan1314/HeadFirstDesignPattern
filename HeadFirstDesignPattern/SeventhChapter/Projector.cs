using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.SeventhChapter
{
    class Projector
    {
        private DvdPlayer dvdPlayer;
        
        public void SetInput(DvdPlayer dvdPlayer)
        {
            this.dvdPlayer = dvdPlayer;
        }

        public void On()
        {

        }

        public void Off()
        {

        }

        public void TvMode()
        {

        }

        public void WideScreenMode()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
