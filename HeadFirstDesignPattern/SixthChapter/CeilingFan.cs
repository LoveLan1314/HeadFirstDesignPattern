using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.SixthChapter
{
    class CeilingFan
    {
        public const int HIGH = 3;
        public const int MEDIUM = 2;
        public const int LOW = 1;
        public const int OFF = 0;
        
        private readonly string location;
        private int speed;
        public CeilingFan(string location)
        {
            this.location = location;
        }

        public void High()
        {
            speed = HIGH;
            Console.WriteLine($"{location} CeilingFan is on high");
        }

        public void Medium()
        {
            speed = MEDIUM;
            Console.WriteLine($"{location} CeilingFan is on medium");
        }

        public void Low()
        {
            speed = LOW;
            Console.WriteLine($"{location} CeilingFan is on low");
        }

        public void Off()
        {
            speed = OFF;
            Console.WriteLine($"{location} CeilingFan is off");
        }

        public int GetSpeed()
        {
            return speed;
        }


        public void On()
        {
            Console.WriteLine($"{location} CeilingFan is on");
        }

        //public void Off()
        //{
        //    Console.WriteLine($"{location} CeilingFan is off");
        //}
    }
}
