using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithm
{
    /// <summary>
    /// Base class of all algotithms
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AlgorithmBase<T> where T: IComparable
    {
        /// <summary>
        /// Swops counter
        /// </summary>
        public int SwopCount { get; protected set; } = 0;

        /// <summary>
        /// Comparsion counter
        /// </summary>
        public int ComparsionCount { get; protected set; } = 0;
        public List<T> Items { get; set; } = new List<T>();

        public event EventHandler<Tuple<T, T>> CompareEvent;
        public event EventHandler<Tuple<T, T>> SwopEvent;
        public event EventHandler<Tuple<int, T>> SetEvent;

        public AlgorithmBase(IEnumerable<T> items)
        {
            Items.AddRange(items);
        }

        public AlgorithmBase() { }
        
        protected void Swop(int positionA, int positionB)
        {
            if (positionA < Items.Count && positionB < Items.Count)
            {
                SwopEvent?.Invoke(this, new Tuple<T, T>(Items[positionA], Items[positionB]));
                SwopCount++;

                var temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;
            }
        }

        protected void Set(int position, T item)
        {
            if (position < Items.Count)
            {
                SetEvent?.Invoke(this, new Tuple<int, T>(position, item));
                Items[position] = item;
            }
        }

        /// <summary>
        /// Sorting elements with timed
        /// </summary>
        /// <returns></returns>
        public TimeSpan Sort()
        {
            SwopCount = 0;
            var timer = new Stopwatch();

            timer.Start();
            MakeSort();
            timer.Stop();

            return timer.Elapsed;
        }

        protected virtual void MakeSort()
        {
            Items.Sort();
        }

        protected int Compare(T a, T b)
        {
            CompareEvent?.Invoke(this, new Tuple<T, T>(a, b));
            ComparsionCount++;
            return a.CompareTo(b);
        }
    }
}
