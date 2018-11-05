using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.FifthChapter
{
    public class Singleton
    {
        private static Singleton _uniqueInstance;

        private Singleton()
        {

        }

        public static Singleton GetSingleton()
        {
            if(_uniqueInstance == null)
            {
                _uniqueInstance = new Singleton();
            }
            return _uniqueInstance;
        }
    }
}
