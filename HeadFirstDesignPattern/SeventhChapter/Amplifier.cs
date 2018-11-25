using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.SeventhChapter
{
    class Amplifier
    {
        private Tuner tuner;
        private DvdPlayer dvdPlayer;
        private CdPlayer cdPlayer;
        
        public void On()
        {

        }

        public void Off()
        {

        }

        public void SetCd(CdPlayer cdPlayer)
        {
            this.cdPlayer = cdPlayer;
        }

        public void SetDvd(DvdPlayer dvdPlayer)
        {
            this.dvdPlayer = dvdPlayer;
        }

        public void SetStereoSound()
        {

        }

        public void SetSurroundSound()
        {

        }

        public void SetTuner(Tuner tuner)
        {
            this.tuner = tuner;
        }

        public void SetVolume(int volume)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
