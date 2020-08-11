using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm
{
    public class MergeSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public MergeSort(IEnumerable<T> items) : base(items) { }
        public MergeSort() { }

        protected override void MakeSort()
        {
            Items = Sort(Items);
        }

        private List<T> Sort(List<T> items)
        {
            if (items.Count == 1)
            {
                return items;
            }

            var mid = items.Count / 2;

            var left = items.Take(mid).ToList();
            var right = items.Skip(mid).ToList();

            return Merge(Sort(left), Sort(right));

        }

        private List<T> Merge(List<T> left, List<T> right)
        {
            var lenght = left.Count + right.Count;
            var leftPionter = 0;
            var rightPointer = 0;

            var result = new List<T>();

            for (int i = 0; i < lenght; i++)
            {
                if (leftPionter < left.Count && rightPointer < right.Count)
                {
                    if (Compare(left[leftPionter], right[rightPointer]) == -1)
                    {
                        result.Add(left[leftPionter]);
                        leftPionter++;
                    }
                    else
                    {
                        result.Add(right[rightPointer]);
                        rightPointer++;
                    }
                }
                else
                {
                    if (rightPointer < right.Count)
                    {
                        result.Add(right[rightPointer]);
                        rightPointer++;
                    }
                    else
                    {
                        result.Add(left[leftPionter]);
                        leftPionter++;
                    }
                }
            }

            return result;
        }
    }
}
