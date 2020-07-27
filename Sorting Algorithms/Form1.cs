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
                VisualizationPanel.Controls.Add(item.VerticalProgressBar);
                VisualizationPanel.Controls.Add(item.Label);
            }

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
                    VisualizationPanel.Controls.Add(item.VerticalProgressBar);
                    VisualizationPanel.Controls.Add(item.Label);
                }
            }

            AmountRandomTextBox.Text = "";
        }  

        private void BubbleSortButton_Click(object sender, EventArgs e)
        {
            var bubble = new BubbleSort<SortedItem>(items);
            bubble.CompareEvent += Bubble_CompareEvent;
            bubble.SwopEvent += Bubble_SwopEvent;
            bubble.Sort();
        }

        private void Bubble_SwopEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            var temp = e.Item1.Value;
            e.Item1.SetValue(e.Item2.Value);
            e.Item2.SetValue(temp);
            VisualizationPanel.Refresh();           
        }

        private void Bubble_CompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Green);            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            items.Clear();
            VisualizationPanel.Controls.Clear();
            VisualizationPanel.Refresh();
        }
    }
}
