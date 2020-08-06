using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    /// <summary>
    /// Selection sort algorithm
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SelectionSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public SelectionSort(IEnumerable<T> items) : base(items) { }
        public SelectionSort() { }

        protected override void MakeSort()
        {
            for (int i = 0; i < Items.Count - 1; i++)
            {
                var minPosition = i;

                for (int j = i + 1; j < Items.Count; j++)
                {
                    if (Compare(Items[minPosition],Items[j]) == 1)
                    {
                        minPosition = j;
                    }
                }

                if (minPosition != i)
                {
                    Swop(minPosition, i);
                }
            }
        }
    }
}
