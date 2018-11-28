using System;

namespace HeadFirstDesignPattern.EighthChapter
{
    internal class Duck : IComparable<Duck>
    {
        private readonly string name;
        private readonly int weight;

        public Duck(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public override string ToString()
        {
            return $"{name} weight {weight}";
        }

        public int CompareTo(Duck other)
        {
            if (weight < other.weight)
            {
                return -1;
            }
            else if (weight == other.weight)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
