using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class QuickSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public QuickSort(IEnumerable<T> items) : base(items) { }
        public QuickSort() { }

        protected override void MakeSort()
        {
            Sort(0, Items.Count - 1);
        }

        private void Sort(int left, int right)
        {
            if (left < right)
            {
                var p = Partition(left, right);
                Sort( left, p - 1);
                Sort( p + 1, right);
            }
        }

        private int Partition(int left, int right)
        {
            var pivot = left;

            for (int i = left; i <= right; i++)
            {
                if (Compare(Items[i], Items[right]) <= 0)
                {
                    Swop(pivot, i);
                    pivot++;
                }
            }

            return pivot - 1;
        }
    }
}
