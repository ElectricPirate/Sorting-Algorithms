﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithm;

namespace Sorting_Algorithms
{
    public partial class Form1 : Form
    {

       List<SortedItem> items = new List<SortedItem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AddTextBox.Text, out int value))
            {
                var item = new SortedItem(value, items.Count);
                items.Add(item);
            }

            RefreshItems();

            AddTextBox.Text = "";
        }

        private void FillRandomButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AmountRandomTextBox.Text, out int value))
            {
                var rnd = new Random();
                for (int i = 0; i < value; i++)
                {
                    var item = new SortedItem(rnd.Next(0, 100), items.Count);
                    items.Add(item);
                }

                #region Добавление неповторяющихся значений
                //for (var i = 0; i < value; i++)
                //{
                //    while (true)
                //    {
                //        var item = new SortedItem(rnd.Next(0, 100), items.Count);

                //        if (!items.Contains(item))
                //        {
                //            items.Add(item);
                //            VisualizationPanel.Controls.Add(item.VerticalProgressBar);
                //            VisualizationPanel.Controls.Add(item.Label);
                //            break;
                //        }
                //    }
                //}
                #endregion

            }

            RefreshItems();

            AmountRandomTextBox.Text = "";
        }

        private void DrawItems(List<SortedItem> items)
        {
            VisualizationPanel.Controls.Clear();
            foreach (var item in items)
            {
                VisualizationPanel.Controls.Add(item.VerticalProgressBar);
                VisualizationPanel.Controls.Add(item.Label);
            }
            VisualizationPanel.Refresh();
        }

        private void RefreshItems()
        {
            foreach (var item in items)
            {
                item.Refresh();
            }

            DrawItems(items);
        }
        
        private void Algorithm_SwopEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            var temp = e.Item1.Number;
            e.Item1.SetPosition(e.Item2.Number);
            e.Item2.SetPosition(temp);
            e.Item1.SetColor(Color.Blue);
            e.Item2.SetColor(Color.Blue);
            VisualizationPanel.Refresh();           
        }

        private void Algorithm_CompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Green);
            VisualizationPanel.Refresh();

            Thread.Sleep(50);

            e.Item1.SetColor(Color.Blue);
            e.Item2.SetColor(Color.Blue);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            items.Clear();
            VisualizationPanel.Controls.Clear();
            VisualizationPanel.Refresh();
        }

        private void BttnSort_Click(AlgorithmBase<SortedItem> algorithm)
        {
            RefreshItems();

            algorithm.CompareEvent += Algorithm_CompareEvent;
            algorithm.SwopEvent += Algorithm_SwopEvent;
            var time = algorithm.Sort();

            TimeLabel.Text = "Time: " + time.Seconds;
            ComparsionsLabel.Text = "Compare: " + algorithm.ComparsionCount;
            SwopsLabel.Text = "Swops: " + algorithm.ComparsionCount;
        }

        private void BubbleSortButton_Click(object sender, EventArgs e)
        {
            var bubble = new BubbleSort<SortedItem>(items);
            BttnSort_Click(bubble);
        }
        private void CocktailSortButton_Click(object sender, EventArgs e)
        {
            var cocktail = new CocktailSort<SortedItem>(items);
            BttnSort_Click(cocktail);
        }

        private void InsertSortButton_Click(object sender, EventArgs e)
        {
            var insert = new InsertSort<SortedItem>(items);
            BttnSort_Click(insert);
        }

        private void ShellSortButton_Click(object sender, EventArgs e)
        {
            var shell = new ShellSort<SortedItem>(items);
            BttnSort_Click(shell);
        }

        private void TreeSortButton_Click(object sender, EventArgs e)
        {
            var tree = new TreeSort<SortedItem>(items);
            BttnSort_Click(tree);
        }

        private void HeapSortButton_Click(object sender, EventArgs e)
        {
            var heap = new HeapSort<SortedItem>(items);
            BttnSort_Click(heap);
        }
    }
}
