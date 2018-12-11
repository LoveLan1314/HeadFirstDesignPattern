namespace HeadFirstDesignPattern.NinthChapter
{
    internal class DinerMenuIterator : IIterator
    {
        private readonly MenuItem[] items;
        private int position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }
        
        public bool HasNext()
        {
            if (position >= items.Length || items[position] == null)
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
            return items[position++];
        }
    }
}
