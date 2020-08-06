using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Algorithm
{
    /// <summary>
    /// Heap class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class HeapSort<T> : AlgorithmBase<T> where T : IComparable
    {
        /// <summary>
        /// Number of elements
        /// </summary>
        public int Count => Items.Count;

        public HeapSort(IEnumerable<T> items)
        {
            Items.AddRange(items);

            for (int i = Count; i >= 0; i--)
            {
                Sort(i);
            }
        }
        protected override void MakeSort()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                Swop(0, i);
                Sort(0, i);
            }
        }

        /// <summary>
        /// Add new element into the heap
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            if (item != null)
            {
                Items.Add(item);

                var currentIndex = Count - 1;
                var parentIndex = GetParentIndex(currentIndex);

                while (currentIndex > 0 && Compare(Items[parentIndex], Items[currentIndex]) == -1)
                {
                    Swop(currentIndex, parentIndex);

                    currentIndex = parentIndex;
                    parentIndex = GetParentIndex(currentIndex);
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(item), $"{item.ToString()} is null.");
            }
        }

        /// <summary>
        /// Pop maximum element
        /// </summary>
        /// <returns></returns>
        public T GetMax()
        {
            var result = Items[0];
            Items[0] = Items[Count - 1];
            Items.RemoveAt(Count - 1);
            Sort(0);
            
            return result;
        }

        private void Sort(int currentIndex, int maxLenght = -1)
        {
            int maxIndex = currentIndex;
            int leftIndex;
            int rightIndex;

            maxLenght = maxLenght == -1 ? Count : maxLenght;

            while (currentIndex < maxLenght)
            {
                leftIndex = 2 * currentIndex + 1;
                rightIndex = 2 * currentIndex + 2;

                if (leftIndex < maxLenght && Compare(Items[leftIndex],Items[maxIndex]) == 1)
                {
                    maxIndex = leftIndex;   
                }

                if (rightIndex < maxLenght && Compare(Items[rightIndex],Items[maxIndex]) == 1)
                {
                    maxIndex = rightIndex;
                }

                if (maxIndex == currentIndex)
                {
                    break;
                }

                Swop(currentIndex, maxIndex);
                currentIndex = maxIndex;
            }
        }

        private static int GetParentIndex(int currentIndex)
        {
            return (currentIndex - 1) / 2;
        }

        /// <summary>
        /// Get sorted collection
        /// </summary>
        /// <returns></returns>
        public List<T> Order()
        {
            var result = new List<T>();

            while (Count > 0)
            {
                result.Add(GetMax());
            }

            return result;
        }
    }
}
