using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace Sorting_Algorithms
{
    public class SortedItem : IComparable
    {
        public VerticalProgressBar VerticalProgressBar { get; private set; }
        public System.Windows.Forms.Label Label { get; private set; }
        public int Value { get; private set; }

        public SortedItem(int value, int number)
        {
            Value = value;
            VerticalProgressBar = new VerticalProgressBar();
            Label = new System.Windows.Forms.Label();

            var x = number * 20;

            Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Label.Location = new System.Drawing.Point(x, 132);
            Label.AutoSize = false;
            Label.TextAlign = ContentAlignment.MiddleCenter;
            Label.Name = "label" + number;
            Label.Size = new System.Drawing.Size(19, 15);
            Label.TabIndex = 6;
            Label.Text = Value.ToString();

            VerticalProgressBar.BackColor = System.Drawing.SystemColors.Control;
            VerticalProgressBar.ForeColor = System.Drawing.SystemColors.Control;
            VerticalProgressBar.Location = new System.Drawing.Point(x, 13);
            VerticalProgressBar.Name = "verticalProgressBar" + number;
            VerticalProgressBar.Size = new System.Drawing.Size(19, 116);
            VerticalProgressBar.Step = 1;
            VerticalProgressBar.TabIndex = number;
            VerticalProgressBar.Maximum = 100;
            VerticalProgressBar.Minimum = 0;
            VerticalProgressBar.Value = Value;
            VerticalProgressBar.Style = Sorting_Algorithms.Styles.Solid;
            VerticalProgressBar.BorderStyle = Sorting_Algorithms.BorderStyles.None;
        }

        public void SetValue(int value)
        {
            Value = value;
            VerticalProgressBar.Value = value;
            Label.Text = value.ToString();
        }

        public void SetColor(Color color)
        {
            VerticalProgressBar.Color = color;
        }

        public int CompareTo(object obj)
        {
            if (obj is SortedItem item)
            {
                return Value.CompareTo(item.Value);
            }
            else
            {
                throw new ArgumentException($"obj is not {nameof(SortedItem)}", nameof(obj));
            }
        }
    }
}
