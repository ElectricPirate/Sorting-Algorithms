using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Sorting_Algorithms
{
    public class SortedItem
    {
        public VerticalProgressBar VerticalProgressBar { get; private set; }
        public System.Windows.Forms.Label Label { get; private set; }
        public int Value { get; set; }

        public SortedItem(int value)
        {
            Value = value;

            VerticalProgressBar = new VerticalProgressBar();
            Label = new System.Windows.Forms.Label();  
            
            Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Label.Location = new System.Drawing.Point(10, 132);
            Label.Name = "label1";
            Label.Size = new System.Drawing.Size(19, 15);
            Label.TabIndex = 6;
            Label.Text = Value.ToString();

            VerticalProgressBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            VerticalProgressBar.Location = new System.Drawing.Point(10, 13);
            VerticalProgressBar.Name = "verticalProgressBar1";
            VerticalProgressBar.Size = new System.Drawing.Size(19, 116);
            VerticalProgressBar.Step = 1;
            VerticalProgressBar.TabIndex = 5;
            VerticalProgressBar.Maximum = 100;
            VerticalProgressBar.Minimum = 0;
            VerticalProgressBar.Value = Value;
        }
    }
}
