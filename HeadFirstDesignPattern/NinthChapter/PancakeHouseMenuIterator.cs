using System.Collections;

namespace HeadFirstDesignPattern.NinthChapter
{
    internal class PancakeHouseMenuIterator : IIterator
    {
        private readonly ArrayList items;
        private int position = 0;

        public PancakeHouseMenuIterator(ArrayList items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            return position < items.Count;
        }

        public object Next()
        {
            return items[position++];
        }
    }
}
