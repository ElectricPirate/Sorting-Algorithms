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

        private void BubbleSortButton_Click(object sender, EventArgs e)
        {
            RefreshItems();

            var bubble = new BubbleSort<SortedItem>(items);
            bubble.CompareEvent += Bubble_CompareEvent;
            bubble.SwopEvent += Bubble_SwopEvent;
            var time = bubble.Sort();
            BubbleTimeLabel.Text = "Time: " + time.Seconds;
            BubbleComparsionsLabel.Text = "Compare: " + bubble.ComparsionCount;
            BubbleSwopsLabel.Text = "Swops: " + bubble.ComparsionCount;
        }
        
        private void Bubble_SwopEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            var temp = e.Item1.Number;
            e.Item1.SetPosition(e.Item2.Number);
            e.Item2.SetPosition(temp);
            e.Item1.SetColor(Color.Blue);
            e.Item2.SetColor(Color.Blue);
            VisualizationPanel.Refresh();           
        }

        private void Bubble_CompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Green);
            VisualizationPanel.Refresh();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            items.Clear();
            VisualizationPanel.Controls.Clear();
            VisualizationPanel.Refresh();
        }
        
    }
}
