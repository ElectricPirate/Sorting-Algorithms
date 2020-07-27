using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                var item = new SortedItem(value);
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
                    var item = new SortedItem(rnd.Next(0, 100));
                    items.Add(item);
                    VisualizationPanel.Controls.Add(item.VerticalProgressBar);
                    VisualizationPanel.Controls.Add(item.Label);
                }
            }

            AmountRandomTextBox.Text = "";
        }       
    }
}
