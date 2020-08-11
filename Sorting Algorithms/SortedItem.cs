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
        public int Number { get; private set; }
        public int StartNumber { get; private set; }
        public int Max { get; set; } = 100;
        public int Min { get; set; } = 0;

        public SortedItem(int value, int number)
        {
            Value = value;
            Number = number;
            StartNumber = number;
            VerticalProgressBar = new VerticalProgressBar();
            Label = new System.Windows.Forms.Label();

            var x = number * 20;

            Label.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Label.Location = new Point(x, 132);
            Label.AutoSize = false;
            Label.TextAlign = ContentAlignment.MiddleCenter;
            Label.Name = "label" + number;
            Label.Size = new Size(19, 15);
            Label.TabIndex = 6;
            Label.Text = Value.ToString();

            VerticalProgressBar.BackColor = SystemColors.Control;
            VerticalProgressBar.ForeColor = SystemColors.Control;
            VerticalProgressBar.Location = new Point(x, 13);
            VerticalProgressBar.Name = "verticalProgressBar" + number;
            VerticalProgressBar.Size = new Size(19, 116);
            VerticalProgressBar.Step = 1;
            VerticalProgressBar.TabIndex = number;
            VerticalProgressBar.Maximum = Max;
            VerticalProgressBar.Minimum = Min;
            VerticalProgressBar.Value = Value;
            VerticalProgressBar.Style = Styles.Solid;
            VerticalProgressBar.BorderStyle = BorderStyles.None;
        }

        public void SetPosition(int number)
        {
            Number = number;
            var x = number * 20;
            VerticalProgressBar.Location = new Point(x, 13);
            VerticalProgressBar.Name = "verticalProgressBar" + number;
            Label.Location = new Point(x, 132);
            Label.Name = "label" + number;
        }

        public void Refresh()
        {
            Number = StartNumber;
            var x = Number * 20;
            VerticalProgressBar.Location = new Point(x, 13);
            VerticalProgressBar.Name = "verticalProgressBar" + Number;
            Label.Location = new Point(x, 132);
            Label.Name = "label" + Number;
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

        public override string ToString()
        {
            return Value.ToString();
        }

        public override int GetHashCode()
        {
            return Value;
        }
    }
}
