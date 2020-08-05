using System;
using System.Collections.Generic;
using System.Text;
using Algorithm.DataStructures;

namespace Algorithm
{
    public class HeapSort<T> : AlgorithmBase<T> where T : IComparable
    {
        protected override void MakeSort()
        {
            var heap = new Heap<T>(Items);
            var sorted = heap.Orger();
            Items = sorted;
        }
    }
}
