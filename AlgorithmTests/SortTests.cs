using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Tests
{
    [TestClass()]
    public class SortTests
    {
        private Random rnd = new Random();
        private List<int> Items = new List<int>();
        List<int> Sorted = new List<int>();

        [TestInitialize]
        public void Init()
        {
            Items.Clear();

            for (var i = 0; i < 10000; i++)
            {
                Items.Add(rnd.Next(0, 100));
            }

            Sorted.Clear();
            Sorted.AddRange(Items.OrderBy(x => x).ToArray());
        }

        [TestMethod()]
        public void BubbleSortTest()
        {
            // Arrange
            var bubble = new BubbleSort<int>();
            bubble.Items.AddRange(Items);

            // Act
            bubble.Sort();

            // Assert
            for (var i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bubble.Items[i]);
            }
        }

        [TestMethod()]
        public void CocktailSortTest()
        {
            // Arrange
            var cocktail = new CocktailSort<int>();
            cocktail.Items.AddRange(Items);

            // Act
            cocktail.Sort();

            // Assert
            for (var i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], cocktail.Items[i]);
            }
        }

        [TestMethod()]
        public void InsertSortTest()
        {
            // Arrange
            var insert = new InsertSort<int>();
            insert.Items.AddRange(Items);

            // Act
            insert.Sort();

            // Assert
            for (var i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], insert.Items[i]);
            }
        }
    }
}