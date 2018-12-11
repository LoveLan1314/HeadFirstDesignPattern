using System;

namespace HeadFirstDesignPattern.NinthChapter
{
    internal class AlternatingDinerMenuIterator : IIterator
    {
        private readonly MenuItem[] _items;
        private int position;

        public AlternatingDinerMenuIterator(MenuItem[] items)
        {
            _items = items;
            DateTime now = DateTime.Now;
            position = now.Day % 2;
        }

        public bool HasNext()
        {
            if (position >= _items.Length || _items[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object Next()
        {
            MenuItem menuItem = _items[position];
            position = position + 2;
            return menuItem;
        }
    }
}
