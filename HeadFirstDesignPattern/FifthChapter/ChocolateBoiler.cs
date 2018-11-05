using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.FifthChapter
{
    public class ChocolateBoiler
    {
        private static ChocolateBoiler _uniqueInstance;
        private bool _empty;
        private bool _boiled;

        private ChocolateBoiler()
        {
            _empty = true;
            _boiled = false;
        }

        //多线程下存在问题
        public static ChocolateBoiler GetInstance()
        {
            if(_uniqueInstance == null)
            {
                _uniqueInstance = new ChocolateBoiler();
            }
            return _uniqueInstance;
        }

        public void Fill()
        {
            if (IsEmpty())
            {
                _empty = false;
                _boiled = false;
            }
        }

        public void Drain()
        {
            if(!IsEmpty() && IsBoiled())
            {
                _empty = true;
            }
        }

        public void Boil()
        {
            if(!IsEmpty() && !IsBoiled())
            {
                _boiled = true;
            }
        }

        public bool IsEmpty()
        {
            return _empty;
        }

        public bool IsBoiled()
        {
            return _boiled;
        }
    }
}
