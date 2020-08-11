using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm
{
    public class RadixMSDSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public RadixMSDSort(IEnumerable<T> items) : base(items) { }

        public RadixMSDSort() { }

        protected override void MakeSort()
        {
            var length = GetMaxLength(Items);
            var result = SortCollection(Items, length - 1);
            Items = result;
        }

        private List<T> SortCollection(List<T> collection, int step)
        {
            var result = new List<T>();

            var groups = new List<List<T>>();

            for (int i = 0; i < 10; i++)
            {
                groups.Add(new List<T>());
            }

            foreach (var item in collection)
            {
                var i = item.GetHashCode();
                var value = i % (int)Math.Pow(10, step + 1) / (int)Math.Pow(10, step);
                groups[value].Add(item);
            }

            collection.Clear();

            foreach (var group in groups)
            {
                if (group.Count > 1 && step > 0)
                {
                    result.AddRange(SortCollection(group, step - 1));
                    continue;
                }

                result.AddRange(group);
            }

            return result;
        }

        private int GetMaxLength(List<T> collection)
        {
            var length = 0;

            foreach (var item in collection)
            {
                if (item.GetHashCode() < 0)
                {
                    throw new ArgumentException("Radix sort work only with integer >= 0", nameof(item));
                }

                //var l = Convert.ToInt32(Math.Log10(item.GetHashCode()) + 1); // didn't work with item = 0, get -inf.

                var l = GetHashCode().ToString().Length;

                if (l > length)
                {
                    length = l;
                }
            }

            return length;
        }
    }
}
