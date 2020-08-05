using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Algorithm.DataStructures
{
    /// <summary>
    /// Heap class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Heap<T> where T : IComparable
    {
        private List<T> items = new List<T>();

        /// <summary>
        /// Number of elements
        /// </summary>
        public int Count => items.Count;

        public Heap() { }

        public Heap(List<T> items)
        {
            this.items.AddRange(items);

            for (int i = Count; i >= 0; i--)
            {
                Sort(i);
            }
        }

        /// <summary>
        /// Peek maximum element
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            if (Count > 0)
            {
                return items[0];
            }
            else
            {
                throw new ArgumentNullException(nameof(items), "Heap is empty.");
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
                items.Add(item);

                var currentIndex = Count - 1;
                var index = GetParentIndex(currentIndex);
                var parentIndex = index;

                while (currentIndex > 0 && items[parentIndex].CompareTo(items[currentIndex]) == 1)
                {
                    Swap(currentIndex, parentIndex);

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
            var result = items[0];
            items[0] = items[Count - 1];
            items.RemoveAt(Count - 1);
            Sort(0);
            return result;
        }

        private void Sort(int currentIndex)
        {
            int maxIndex = currentIndex;
            int leftIndex;
            int rightIndex;

            while (currentIndex < Count)
            {
                leftIndex = 2 * currentIndex + 1;
                rightIndex = 2 * currentIndex + 2;

                if (leftIndex < Count && items[leftIndex].CompareTo(items[maxIndex]) == -1)
                {
                    maxIndex = leftIndex;
                }

                if (rightIndex < Count && items[rightIndex].CompareTo(items[maxIndex]) == -1)
                {
                    maxIndex = rightIndex;
                }

                if (maxIndex == currentIndex)
                {
                    break;
                }

                Swap(currentIndex, maxIndex);
                currentIndex = maxIndex;
            }
        }

        private void Swap(int currentIndex, int parentIndex)
        {
            var temp = items[currentIndex];
            items[currentIndex] = items[parentIndex];
            items[parentIndex] = temp;
        }

        private static int GetParentIndex(int currentIndex)
        {
            return (currentIndex - 1) / 2;
        }

        /// <summary>
        /// Get sorted collection
        /// </summary>
        /// <returns></returns>
        public List<T> Orger()
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
