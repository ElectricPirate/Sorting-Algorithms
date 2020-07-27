using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Tests
{
    [TestClass()]
    public class BubbleSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            // Arrange
            var bubble = new BubbleSort<int>();
            var items = new List<int>();

            var rnd = new Random();

            for (var i = 0; i < 10000; i++)
            {
                items.Add(rnd.Next(0, 100));
            }

            bubble.Items.AddRange(items);
            var sorted = items.OrderBy(x => x).ToArray();

            // Act
            bubble.Sort();

            // Assert
            for (var i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], bubble.Items[i]);
            }
        }
    }
}