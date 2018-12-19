using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.TwelfthChapter
{
    class Flock : IQuackable
    {
        private readonly List<IQuackable> _quackables = new List<IQuackable>();

        public void Add(IQuackable quackable)
        {
            _quackables.Add(quackable);
        }

        public void NotifyObservers()
        {
            //如果保持与其他地方逻辑一致的话，此处应该是循环调用所有IQuackable的NotifyObservers方法
            //foreach (var item in _quackables)
            //{
            //    item.NotifyObservers();
            //}
        }

        public void Quack()
        {
            foreach (var item in _quackables)
            {
                item.Quack();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            foreach (var item in _quackables)
            {
                item.RegisterObserver(observer);
            }
        }
    }
}
