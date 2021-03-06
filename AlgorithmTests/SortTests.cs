﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Algorithm.DataStructures;

namespace Algorithm.Tests
{
    [TestClass()]
    public class SortTests
    {
        private Random rnd = new Random();
        private List<int> Items = new List<int>();
        List<int> Sorted = new List<int>();
        private int numbers = 12;
        private int minNumber = 0;
        private int maxNumber = 10;

        [TestInitialize]
        public void Init()
        {
            Items.Clear();

            for (var i = 0; i < numbers; i++)
            {
                var tmp = rnd.Next(minNumber, maxNumber);

                #region Добавление неповторяющихся значений
                //while (true)
                //{
                //    var tmp = rnd.Next(minNumber, maxNumber);

                //    if (!Items.Contains(tmp))
                //    {
                //        Items.Add(tmp);
                //        break;
                //    }
                //}
                #endregion
                
                Items.Add(tmp);
            }

            Sorted.Clear();
            Sorted.AddRange(Items.OrderBy(x => x).ToArray());
        }

        [TestMethod()]
        public void BaseSortTest()
        {
            // Arrange
            var bases = new AlgorithmBase<int>();
            bases.Items.AddRange(Items);

            // Act
            bases.Sort();

            // Assert
            for (var i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bases.Items[i]);
            }
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

        [TestMethod()]
        public void ShellSortTest()
        {
            // Arrange
            var shell = new ShellSort<int>();
            shell.Items.AddRange(Items);

            // Act
            shell.Sort();

            // Assert
            for (var i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], shell.Items[i]);
            }
        }

        [TestMethod()]
        public void TreeSortTest()
        {
            // Arrange
            var tree = new TreeSort<int>(Items);

            // Act
            tree.Sort();

            // Assert
            for (var i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], tree.Items[i]);
            }
        }

        [TestMethod()]
        public void HeapSortTest()
        {
            // Arrange
            var heap = new HeapSort<int>(Items);

            // Act
            heap.Sort();

            // Assert
            for (var i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], heap.Items[i]);
            }
        }

        [TestMethod()]
        public void SelectSortTest()
        {
            // Arrange
            var select = new SelectionSort<int>();
            select.Items.AddRange(Items);

            // Act
            select.Sort();

            // Assert
            for (var i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], select.Items[i]);
            }
        }

        [TestMethod()]
        public void GnomeSortTest()
        {
            // Arrange
            var gnome = new GnomeSort<int>();
            gnome.Items.AddRange(Items);

            // Act
            gnome.Sort();

            // Assert
            for (var i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], gnome.Items[i]);
            }
        }

        [TestMethod()]
        public void RadixLSDSortTest()
        {
            // Arrange
            var radixLSD = new RadixLSDSort<int>();
            radixLSD.Items.AddRange(Items);

            // Act
            radixLSD.Sort();

            // Assert
            for (var i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], radixLSD.Items[i]);
            }
        }

        [TestMethod()]
        public void RadixMSDSortTest()
        {
            // Arrange
            var radixMSD = new RadixMSDSort<int>();
            radixMSD.Items.AddRange(Items);

            // Act
            radixMSD.Sort();

            // Assert
            for (var i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], radixMSD.Items[i]);
            }
        }

        [TestMethod()]
        public void MergeSortTest()
        {
            // Arrange
            var merge = new MergeSort<int>();
            merge.Items.AddRange(Items);

            // Act
            merge.Sort();

            // Assert
            for (var i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], merge.Items[i]);
            }
        }

        [TestMethod()]
        public void QuickSortTest()
        {
            // Arrange
            var quick = new QuickSort<int>();
            quick.Items.AddRange(Items);

            // Act
            quick.Sort();

            // Assert
            for (var i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], quick.Items[i]);
            }
        }

        [TestMethod()]
        public void BogoSortTest()
        {
            // Arrange
            var bogo = new BogoSort<int>();
            bogo.Items.AddRange(Items);

            // Act
            bogo.Sort();

            // Assert
            for (var i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bogo.Items[i]);
            }
        }
    }
}