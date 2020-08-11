using System;
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
using Algorithm.DataStructures;

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
        
        private void AlgorithmSwopEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Aqua);
            e.Item2.SetColor(Color.Brown);
            VisualizationPanel.Refresh();

            Thread.Sleep(20);

            var temp = e.Item1.Number;
            e.Item1.SetPosition(e.Item2.Number);
            e.Item2.SetPosition(temp);
            VisualizationPanel.Refresh();

            Thread.Sleep(20);

            e.Item1.SetColor(Color.Blue);
            e.Item2.SetColor(Color.Blue);
            VisualizationPanel.Refresh();

            Thread.Sleep(20);
        }

        private void AlgorithmCompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Green);
            VisualizationPanel.Refresh();

            Thread.Sleep(20);

            e.Item1.SetColor(Color.Blue);
            e.Item2.SetColor(Color.Blue);
            VisualizationPanel.Refresh();

            Thread.Sleep(20);
        }

        private void AlgorithmSetEvent(object sender, Tuple<int, SortedItem> e)
        {
            e.Item2.SetColor(Color.Red);
            VisualizationPanel.Refresh();
            Thread.Sleep(20);

            e.Item2.SetPosition(e.Item1);
            VisualizationPanel.Refresh();
            Thread.Sleep(20);

            e.Item2.SetColor(Color.Blue);
            VisualizationPanel.Refresh();
            Thread.Sleep(20);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            items.Clear();
            VisualizationPanel.Controls.Clear();
            VisualizationPanel.Refresh();

            TimeLabel.Text = "Time: ";
            ComparsionsLabel.Text = "Compare: ";
            SwopsLabel.Text = "Swops: ";
        }

        private void BttnSort_Click(AlgorithmBase<SortedItem> algorithm)
        {
            RefreshItems();

            for (int i = 0; i < algorithm.Items.Count; i++)
            {
                algorithm.Items[i].SetPosition(i);
            }

            VisualizationPanel.Refresh();

            algorithm.CompareEvent += AlgorithmCompareEvent;
            algorithm.SwopEvent += AlgorithmSwopEvent;
            algorithm.SetEvent += AlgorithmSetEvent;
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

        private void SelectionSortButton_Click(object sender, EventArgs e)
        {
            var selection = new SelectionSort<SortedItem>(items);
            BttnSort_Click(selection);
        }

        private void HeapSortButton_Click(object sender, EventArgs e)
        {
            var heap = new HeapSort<SortedItem>(items);
            BttnSort_Click(heap);
        }

        private void GnomeSortButton_Click(object sender, EventArgs e)
        {
            var gnome = new GnomeSort<SortedItem>(items);
            BttnSort_Click(gnome);
        }

        private void TreeSortButton_Click_1(object sender, EventArgs e)
        {
            var tree = new TreeSort<SortedItem>(items);
            BttnSort_Click(tree);
        }

        private void MergeSortButton_Click(object sender, EventArgs e)
        {
            var merge = new MergeSort<SortedItem>(items);
            BttnSort_Click(merge);
        }

        private void RadixLSDSortButton_Click(object sender, EventArgs e)
        {
            var radixLsd = new RadixLSDSort<SortedItem>(items);
            BttnSort_Click(radixLsd);
        }

        private void RadixMSDSortButton_Click(object sender, EventArgs e)
        {
            var radixMsd = new RadixMSDSort<SortedItem>(items);
            BttnSort_Click(radixMsd);
        }
    }
}
