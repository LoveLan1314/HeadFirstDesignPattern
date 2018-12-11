using System;
using System.Collections;

namespace HeadFirstDesignPattern.NinthChapter
{
    internal class CafeMenuIterator : IIterator
    {
        private readonly Hashtable _items;

        public CafeMenuIterator(Hashtable items)
        {
            _items = items;
        }

        public bool HasNext()
        {
            throw new NotImplementedException();
        }

        public object Next()
        {
            throw new NotImplementedException();
        }
    }
}
