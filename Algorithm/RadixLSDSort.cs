﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm
{
    public class RadixLSDSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public RadixLSDSort(IEnumerable<T> items) : base(items) { }

        public RadixLSDSort() { }

        protected override void MakeSort()
        {
            var groups = new List<List<T>>();

            for (int i = 0; i < 10; i++)
            {
                groups.Add(new List<T>());
            }

            var length = GetMaxLength();
            
            for (var step = 0; step < length; step++)
            {
                foreach (var item in Items)
                {
                    var i = item.GetHashCode();
                    var value = i % (int)Math.Pow(10, step + 1) / (int)Math.Pow(10, step);
                    groups[value].Add(item);
                }

                Items.Clear();

                foreach (var group in groups)
                {
                    foreach (var item in group)
                    {
                        Items.Add(item);
                    }
                }

                foreach (var group in groups)
                {
                    group.Clear();
                }
            }
        }

        private int GetMaxLength()
        {
            var length = 0;

            foreach (var item in Items)
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
