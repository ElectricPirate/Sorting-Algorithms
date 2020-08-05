using System;
using System.Collections.Generic;
using System.Text;
using Algorithm.DataStructures;

namespace Algorithm
{
    /// <summary>
    /// Tree sorting algorithm
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TreeSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public TreeSort(IEnumerable<T> items) : base(items) { }
        public TreeSort() { }
        protected override void MakeSort()
        {
            var tree = new Tree<T>(Items);
            var sorted = tree.Inorder();
            Items = sorted;
        }
    }
}
