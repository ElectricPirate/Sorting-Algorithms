using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class BogoSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public BogoSort(IEnumerable<T> items) : base(items) { }

        public BogoSort() { }

        protected override void MakeSort()
        {
            while (!Correct())
            {
                Shuffle();
            }
        }

        private bool Correct()
        {
            for (int i = 0; i < Items.Count - 1; i++)
            {
                if (Compare(Items[i], Items[i + 1]) == 1)
                {
                    return false;
                }
            }

            return true;
        }

        private void Shuffle()
        {
            var rnd = new Random();

            for (int i = 0; i < Items.Count; i++)
            {
                Swop(i, rnd.Next(0, Items.Count) % Items.Count);
            }
        }
    }
}
